using System;
using System.Threading;

namespace DataCollector
{
    class Program
    {
        public static Guid clientIdentifier = Guid.NewGuid();
        //static Dictionary<string, string> counters;
        static void Main(string[] args)
        {
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
                sendDataItem.Id = clientIdentifier;
                s.Send(sendDataItem, "http://localhost:5387/api/v1/dataaccumulator");
                Console.WriteLine($"{DateTime.Now}         Data was send");
            }
            Console.ReadKey();
        }
    }
}
