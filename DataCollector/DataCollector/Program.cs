﻿using System;
using System.IO;
using System.Net.Http;
using System.Threading;
using Microsoft.Extensions.Configuration;

namespace DataCollector
{
    internal class Program
    {
        public static Guid ClientIdentifier;

        public static Timer TimerItem;

        //event for exiting by pressing ctrl+c
        private static readonly AutoResetEvent Closing = new AutoResetEvent(false);
        public static IConfiguration Configuration { get; set; }

        private static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            Configuration = builder.Build();

            var uri = Configuration.GetConnectionString("DataAccumulator");
            int.TryParse(Configuration.GetSection("Delay").Value, out var delay);

            ClientIdentifier = ConfigureClientIdentifier();
            if (ClientIdentifier == Guid.Empty)
                while (true)
                    try
                    {
                        Console.WriteLine("Enter valid instance id that you got from site");
                        var id = Guid.Parse(Console.ReadLine());
                        ClientIdentifier = id;
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please, enter valid value");
                        Thread.Sleep(100);
                        Console.Clear();
                    }

            Console.Clear();
            Console.WriteLine("Initializating...");
            // sender and collector for timer
            var payload = (
                new DataSender(new HttpClient(), uri),
                Collector.Instance);

            // setting timer for collecting proccess
            TimerItem = new Timer(Timercallback, payload, 0, delay);


            Console.CancelKeyPress += OnExit;
            Closing.WaitOne();
        }

        protected static void OnExit(object sender, EventArgs e)
        {
            Console.WriteLine("Exiting...");
            SaveGuid();
            Closing.Set();
            Environment.Exit(0);
        }

        protected static void SaveGuid()
        {
            var currentDir = Directory.GetCurrentDirectory();
            if (ClientIdentifier != Guid.Empty)
                using (var writer = new StreamWriter($@"{currentDir}\\guid.txt"))
                {
                    writer.Write(ClientIdentifier.ToString());
                }
        }

        protected static Guid ConfigureClientIdentifier()
        {
            var currentDir = Directory.GetCurrentDirectory();
            var fileInfo = new FileInfo($@"{currentDir}\\guid.txt");
            var guidId = Guid.Empty;
            if (!fileInfo.Exists) return Guid.Empty;
            using (var reader = new StreamReader(fileInfo.OpenRead()))
            {
                var guidString = reader.ReadToEnd();
                if (!Guid.TryParse(guidString, out guidId))
                    return Guid.Empty;
            }

            return guidId;
        }

        public static async void Timercallback(object payload)
        {
            Console.WriteLine($"Current instance: {ClientIdentifier}");

            var turple = (ValueTuple<DataSender, Collector>) payload;

            var sender = turple.Item1;
            var collector = turple.Item2;

            var sendDataItem = new CollectedData();

            var count = 1;
            while (!collector.Data.IsEmpty)
            {
                collector.Data.TryTake(out var tempDataItem);
                sendDataItem += tempDataItem;
                count++;
            }

            sendDataItem /= count;
            sendDataItem.Id = ClientIdentifier;

            Console.Clear();
            Console.WriteLine($"{DateTime.Now}\n Average info:\n{sendDataItem}");
            try
            {
                if (await sender.SendAsync(sendDataItem))
                    Console.WriteLine($"{DateTime.Now}\t Data was sent successfully");
                else
                    Console.WriteLine($"{DateTime.Now}\t Data wasn`t sent successfully");
            }
            catch (Exception)
            {
                Console.WriteLine($"{DateTime.Now}\t Data wasn`t sent successfully");
            }

            Console.WriteLine("Press ctr+c for exit");
        }
    }
}