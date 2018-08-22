namespace Watcher.Common.Dtos
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    public class MarketPrice
    {
        public static int Counter { get; set; } = 0;

        //public static List<MarketPrice> MarketPositions { get; set; } = new List<MarketPrice>
        //    {
        //        new MarketPrice { Date = DateTime.ParseExact("10-05-2012", "dd-mm-yyyy", CultureInfo.InvariantCulture), Close = 68.55, Open = 74.55 },
        //        new MarketPrice { Date = DateTime.ParseExact("9-05-2012", "dd-mm-yyyy", CultureInfo.InvariantCulture), Close = 74.55, Open = 69.55 },
        //        new MarketPrice { Date = DateTime.ParseExact("8-05-2012", "dd-mm-yyyy", CultureInfo.InvariantCulture), Close = 69.55, Open = 62.55 },
        //        new MarketPrice { Date = DateTime.ParseExact("7-05-2012", "dd-mm-yyyy", CultureInfo.InvariantCulture), Close = 62.55, Open = 56.55 },
        //        new MarketPrice { Date = DateTime.ParseExact("6-05-2012", "dd-mm-yyyy", CultureInfo.InvariantCulture), Close = 56.55, Open = 59.55 },
        //        new MarketPrice { Date = DateTime.ParseExact("5-05-2012", "dd-mm-yyyy", CultureInfo.InvariantCulture), Close = 59.86, Open = 65.86 },
        //        new MarketPrice { Date = DateTime.ParseExact("4-05-2012", "dd-mm-yyyy", CultureInfo.InvariantCulture), Close = 62.62, Open = 65.62 },
        //        new MarketPrice { Date = DateTime.ParseExact("3-05-2012", "dd-mm-yyyy", CultureInfo.InvariantCulture), Close = 64.48, Open = 60.48 },
        //        new MarketPrice { Date = DateTime.ParseExact("2-05-2012", "dd-mm-yyyy", CultureInfo.InvariantCulture), Close = 60.98, Open = 55.98 },
        //        new MarketPrice { Date = DateTime.ParseExact("1-05-2012", "dd-mm-yyyy", CultureInfo.InvariantCulture), Close = 58.13, Open = 53.13 },
        //        new MarketPrice { Date = DateTime.ParseExact("29-04-2012", "dd-mm-yyyy", CultureInfo.InvariantCulture), Close = 69.55, Open = 62.55 },
        //        new MarketPrice { Date = DateTime.ParseExact("28-04-2012", "dd-mm-yyyy", CultureInfo.InvariantCulture), Close = 62.55, Open = 56.55 },
        //        new MarketPrice { Date = DateTime.ParseExact("27-04-2012", "dd-mm-yyyy", CultureInfo.InvariantCulture), Close = 56.55, Open = 59.55 },
        //        new MarketPrice { Date = DateTime.ParseExact("26-04-2012", "dd-mm-yyyy", CultureInfo.InvariantCulture), Close = 59.86, Open = 65.86 },
        //        new MarketPrice { Date = DateTime.ParseExact("25-04-2012", "dd-mm-yyyy", CultureInfo.InvariantCulture), Close = 62.62, Open = 65.62 },
        //        new MarketPrice { Date = DateTime.ParseExact("24-04-2012", "dd-mm-yyyy", CultureInfo.InvariantCulture), Close = 64.48, Open = 60.48},
        //        new MarketPrice { Date = DateTime.ParseExact("23-04-2012", "dd-mm-yyyy", CultureInfo.InvariantCulture), Close = 60.98, Open = 55.98 },
        //        new MarketPrice { Date = DateTime.ParseExact("22-04-2012", "dd-mm-yyyy", CultureInfo.InvariantCulture), Close = 58.13, Open = 53.13 },
        //        new MarketPrice { Date = DateTime.ParseExact("21-04-2012", "dd-mm-yyyy", CultureInfo.InvariantCulture), Close = 56.13, Open = 51.13 },
        //    };

        public static List<MarketPrice> MarketPositions { get; set; } = new List<MarketPrice>
            {
                new MarketPrice { Date = new DateTime(2012, 5, 11), Close = 69.55, Open = 75.55 },
                new MarketPrice { Date = new DateTime(2012, 5, 10), Close = 68.55, Open = 74.55 },
                new MarketPrice { Date = new DateTime(2012, 5, 9), Close = 74.55, Open = 69.55 },
                new MarketPrice { Date = new DateTime(2012, 5, 8), Close = 69.55, Open = 62.55 },
                new MarketPrice { Date = new DateTime(2012, 5, 7), Close = 62.55, Open = 56.55 },
                new MarketPrice { Date = new DateTime(2012, 5, 6), Close = 56.55, Open = 59.55 },
                new MarketPrice { Date = new DateTime(2012, 5, 5), Close = 59.86, Open = 65.86 },
                new MarketPrice { Date = new DateTime(2012, 5, 4), Close = 62.62, Open = 65.62 },
                new MarketPrice { Date = new DateTime(2012, 5, 3), Close = 64.48, Open = 60.48 },
                new MarketPrice { Date = new DateTime(2012, 5, 2), Close = 60.98, Open = 55.98 },
                new MarketPrice { Date = new DateTime(2012, 5, 1), Close = 58.13, Open = 53.13 },
                new MarketPrice { Date = new DateTime(2012, 4, 29), Close = 69.55, Open = 62.55 },
                new MarketPrice { Date = new DateTime(2012, 4, 28), Close = 62.55, Open = 56.55 },
                new MarketPrice { Date = new DateTime(2012, 4, 27), Close = 56.55, Open = 59.55 },
                new MarketPrice { Date = new DateTime(2012, 4, 26), Close = 59.86, Open = 65.86 },
                new MarketPrice { Date = new DateTime(2012, 4, 25),  Close = 62.62, Open = 65.62 },
                new MarketPrice { Date = new DateTime(2012, 4, 24),  Close = 64.48, Open = 60.48},
                new MarketPrice { Date = new DateTime(2012, 4, 23),  Close = 60.98, Open = 55.98 },
                new MarketPrice { Date = new DateTime(2012, 4, 22),  Close = 58.13, Open = 53.13 },
                new MarketPrice { Date = new DateTime(2012, 4, 21),  Close = 56.13, Open = 51.13 },
            };

        public static void UpdateMarket()
        {
            var diff = Math.Floor(new Random().NextDouble() * 1000) / 100;
            var lastDay = MarketPositions[0].Date.AddDays(1);
            var open = 0d;
            var close = 0d;

            if (Counter % 2 == 0)
            {
                open = MarketPositions[0].Open + diff;
                close = MarketPositions[0].Close + diff;
            }
            else
            {
                open = Math.Abs(MarketPositions[0].Open - diff);
                close = Math.Abs(MarketPositions[0].Close - diff);
            }

            MarketPositions.Insert(0, new MarketPrice { Date = lastDay, Close = close, Open = open });

            Counter++;
        }

        public double Open { get; set; }
        public double Close { get; set; }
        public DateTime Date { get; set; }
    }
}
