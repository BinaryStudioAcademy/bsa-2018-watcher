using System;

namespace DataAccumulator.Shared.Interfaces
{
    public interface ICollectedDataDto
    {
        Guid Id { get; set; }
        Guid ClientId { get; set; }
    }
}
