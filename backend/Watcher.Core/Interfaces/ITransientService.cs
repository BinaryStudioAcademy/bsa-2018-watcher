namespace Watcher.Core.Interfaces
{
    using System.Threading.Tasks;

    using Watcher.Common.Dtos;

    public interface ITransientService
    {
        Task<SampleDto> GenerateRandomSampleDtoAsync();
    }
}
