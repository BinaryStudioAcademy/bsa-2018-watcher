using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Threading;

namespace DataCollector
{
    class Program
    {
        public static Guid clientIdentifier;
        public static IConfiguration Configuration { get; set; }
        public static Timer _timerItem;
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
                        Thread.Sleep(10);
                        Console.Clear();
                    }
                }
            }
            Console.Clear();

            Console.WriteLine($"Current instance: {clientIdentifier}");
            var sender = new DataSender(new System.Net.Http.HttpClient(), uri);

            _timerItem = new Timer(timercallback, sender, 0, delay);

            Console.CancelKeyPress += new ConsoleCancelEventHandler(OnExit);
            _closing.WaitOne();
        }

        protected static void OnExit(object sender, ConsoleCancelEventArgs args)
        {
            Console.WriteLine("Exiting...");
            var currentDir = Directory.GetCurrentDirectory();
            if (clientIdentifier != Guid.Empty)
            {
                using (StreamWriter writer = new StreamWriter($@"{currentDir}\\guid.txt"))
                {
                    writer.Write(clientIdentifier.ToString());
                }
            }
            _closing.Set();
            Environment.Exit(0);
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
            var sender = (DataSender)payload;
            var collector = new Collector();
            try
            {
                collector.Collect();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error on this iteration");
                Console.WriteLine(e.Message);
            }

            var tempDataItem = new CollectedData();
            var sendDataItem = new CollectedData();

            while (!collector.data.IsEmpty)
                {
                  collector.data.TryTake(out tempDataItem);
                  sendDataItem += tempDataItem;
                }

            Console.Clear();
            Console.WriteLine($"{DateTime.Now}\n Average info:\n{sendDataItem.ToString()}");

            sendDataItem.Id = clientIdentifier;
            if (await sender.SendAsync(sendDataItem))
            {
                Console.WriteLine($"{DateTime.Now}\t Data was sent successfully");
            }
            else
            {
                Console.WriteLine($"{DateTime.Now}\t Data wasn`t sent successfully");
            }
            Console.WriteLine("Press ctr+c for exit");
        }
    }
}
