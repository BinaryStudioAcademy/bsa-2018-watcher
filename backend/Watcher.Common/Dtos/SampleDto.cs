namespace Watcher.Common.Dtos
{
    using System;

    using Watcher.Common.Enums;
    using Watcher.Common.Interfaces.Entities;

    public class SampleDto : IEntity<int>
    {
        public SampleDto() { }

        public SampleDto(int num, SampleEnum @enum, string name)
        {
            Id = num;
            Count = num;
            SampleField = @enum;
            Name = name;
            DateOfCreation = DateTime.UtcNow;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Count { get; set; }

        public DateTime DateOfCreation { get; set; }

        public SampleEnum SampleField { get; set; }
    }
}
