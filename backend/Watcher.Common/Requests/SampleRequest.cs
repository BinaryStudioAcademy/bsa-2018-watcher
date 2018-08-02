namespace Watcher.Common.Requests
{
    using System;

    using Watcher.Common.Enums;

    public class SampleRequest
    {
        public string Name { get; set; }

        public int Count { get; set; }

        public DateTime DateOfCreation { get; set; }

        public SampleEnum SampleField { get; set; }
    }
}
