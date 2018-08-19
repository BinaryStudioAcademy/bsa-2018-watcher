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
            Guid clientIdentifier = Guid.NewGuid();

            //DataReceiver rs = new DataReceiver(9050, IPAddress.Loopback);
            DataSender s = new DataSender();
            var collector = new Collector();
            collector.Start();
            while (true)
            {
                Thread.Sleep(10000);
                var tempDataItem = new CollectedData();
                var sendDataItem = new CollectedData();
                sendDataItem.Id = clientIdentifier;

                int count = 0;
                while (!collector.data.IsEmpty)
                {
                    collector.data.TryTake(out tempDataItem);
                    sendDataItem += tempDataItem;
                    count++;
                }

                Console.WriteLine($"{DateTime.Now}         Avarage counted\n");
                sendDataItem /= count;
                Console.WriteLine($"{DateTime.Now}         Avarage:\n{sendDataItem.ToString()}");
                s.Send(sendDataItem, "http://localhost:52106/api/v1/dataaccumulator");
                Console.WriteLine($"{DateTime.Now}         Data was send");
                //rs.Receive();
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
