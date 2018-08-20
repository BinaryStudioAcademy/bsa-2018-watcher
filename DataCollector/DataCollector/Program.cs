using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Net.Http;
using System.Threading;

namespace DataCollector
{
    class Program
    {
        public static Guid clientIdentifier;
        public static IConfiguration Configuration { get; set; }
        public static Timer _timerItem;
        //event for exiting by pressing ctrl+c
        private static readonly AutoResetEvent _closing = new AutoResetEvent(false);

        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");
            Configuration = builder.Build();

            var uri = Configuration.GetConnectionString("DataAccumulator");
            int.TryParse(Configuration.GetSection("Delay").Value, out int delay);
    
            clientIdentifier = ConfigureClientIdentifier();
            if(clientIdentifier == Guid.Empty)
            {
                while(true)
                {
                    try
                    {
                        Console.WriteLine("Enter valid instance id that you got from site");
                        var id = Guid.Parse(Console.ReadLine());
                        clientIdentifier = id;
                        break;
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Please, enter valid value");
                        Thread.Sleep(100);
                        Console.Clear();
                    }
                }
            }
            Console.Clear();
            Console.WriteLine("Initializating...");
            // sender and collector for timer
            var payload = (
                new DataSender(new HttpClient(), uri), 
                Collector.Instance);

            // setting timer for collecting proccess
            _timerItem = new Timer(timercallback, payload, 0, delay);


            //two events for exit 
            Console.CancelKeyPress += (object sender, ConsoleCancelEventArgs e) => {
                Console.WriteLine("Exiting...");
                SaveGuid();
                _closing.Set();
                Environment.Exit(0);
            };
            AppDomain.CurrentDomain.ProcessExit += (object sender, EventArgs e) => SaveGuid();
            _closing.WaitOne();
        }

        protected static void SaveGuid()
        {
            var currentDir = Directory.GetCurrentDirectory();
            if (clientIdentifier != Guid.Empty)
            {
                using (StreamWriter writer = new StreamWriter($@"{currentDir}\\guid.txt"))
                {
                    writer.Write(clientIdentifier.ToString());
                }
            }
        }

        protected static Guid ConfigureClientIdentifier()
        {
            var currentDir = Directory.GetCurrentDirectory();
            var fileInfo = new FileInfo($@"{currentDir}\\guid.txt");
            var guidId = Guid.Empty;
            if (!fileInfo.Exists) return Guid.Empty;
            using (StreamReader reader = new StreamReader(fileInfo.OpenRead()))
            {
                var guidString = reader.ReadToEnd();
                if (!Guid.TryParse(guidString, out guidId))
                    return Guid.Empty;  
            }
            return guidId;
        }

        public static async void timercallback(object payload)
        {
            Console.WriteLine($"Current instance: {clientIdentifier}");

            var turple = (ValueTuple<DataSender, Collector>)payload;

            var sender = turple.Item1;
            var collector = turple.Item2;

            var tempDataItem = new CollectedData();
            var sendDataItem = new CollectedData();

            int count = 1;
            while (!collector.data.IsEmpty)
                {
                  collector.data.TryTake(out tempDataItem);
                  sendDataItem += tempDataItem;
                count++;
                }
            sendDataItem /= count;
            sendDataItem.Id = clientIdentifier;

            Console.Clear();
            Console.WriteLine($"{DateTime.Now}\n Average info:\n{sendDataItem.ToString()}");
            try
            {
                if (await sender.SendAsync(sendDataItem))
                {
                    Console.WriteLine($"{DateTime.Now}\t Data was sent successfully");
                }
                else
                {
                    Console.WriteLine($"{DateTime.Now}\t Data wasn`t sent successfully");
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"{DateTime.Now}\t Data wasn`t sent successfully");
            }
            Console.WriteLine("Press ctr+c for exit");
        }
    }
}
