using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Net.Sockets;
using System.Xml.Serialization;
using System.Net;

namespace DataCollector
{
    class Program
    {
        //static Dictionary<string, string> counters;
        static void Main(string[] args)
        {
            DataReceiver rs = new DataReceiver(9050, IPAddress.Loopback);
            DataSender s = new DataSender("127.0.0.1", 9050);
            
            /*TcpClient socket = new TcpClient("localhost", 122);
            byte[] buffer = new byte[1024];
            int bytes = socket.GetStream().Read(buffer, 0, 100);
            XmlSerializer s = new XmlSerializer(typeof(CollectedData));
            s.Deserialize(socket.GetStream());*/

            var collector = new Collector();
            collector.Start();
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(10000);
                var dataItem = new CollectedData();
                while (!collector.data.IsEmpty)
                {
                    collector.data.TryTake(out dataItem);
                    //Console.WriteLine($"{dataItem.CpuUsagePercent}  {dataItem.Time}     {dataItem.ProcessesCount}");
                    s.Send(dataItem);
                    rs.Receive();
                }
            }
            /*
            counters = new Dictionary<string, string>();
            counters.Add("Processes", "System");
            counters.Add("% Committed Bytes In Use", "Memory");
            counters.Add("Available MBytes", "Memory");
            counters.Add("% Processor Time", "Processor Information");
            counters.Add("Interrupts/sec", "Processor");
            counters.Add("% Interrupt Time", "Processor");
            counters.Add("% Free Space", "LogicalDisk");
            counters.Add("Free Megabytes", "LogicalDisk");
            foreach (var item in counters)
            {
                var dataElement = GetDataElement(item.Value, item.Key);
                Console.WriteLine($"Category: {dataElement.CategoryName}, Counter: {dataElement.CounterName}, Value: {dataElement.Value}");
            }

    */

            Console.ReadKey();
        }

        //static VmData GetDataElement(string categoryName, string counterName)
        //{
        //    PerformanceCounter counter;

        //    if(!categoryName.Contains("Processor") && categoryName!="LogicalDisk")
        //        counter = new PerformanceCounter(categoryName, counterName);
        //    else
        //        counter = new PerformanceCounter(categoryName, counterName, "_Total");
        //    var result = new VmData(counter.CategoryName, counter.CounterName);
        //    result.Value = counter.NextValue();
        //    Thread.Sleep(500);
        //    result.Value = counter.NextValue();
        //    return result;
        //}
    }
}
