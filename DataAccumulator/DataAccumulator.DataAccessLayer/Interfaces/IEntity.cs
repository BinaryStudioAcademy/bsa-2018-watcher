using System;

namespace DataAccumulator.DataAccessLayer.Interfaces
{
    public interface IEntity
    {
        Guid Id { get; set; }
        Guid ClientId { get; set; }
    }
}
