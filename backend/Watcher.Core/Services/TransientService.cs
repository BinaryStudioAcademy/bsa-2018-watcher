namespace Watcher.Core.Services
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Watcher.Common.Dtos;
    using Watcher.Common.Enums;
    using Watcher.Core.Interfaces;

    public class TransientService : ITransientService
    {
        private readonly Random _random;

        public TransientService()
        {
            _random = new Random();
        }

        public Task<SampleDto> GenerateRandomSampleDtoAsync()
        {
            // Initate asynchonous call
            return Task.Run(
                () =>
                    {
                        var randomNumber = _random.Next(0, 100000); //for ints
                        var randomEnum = _random.Next((int)SampleEnum.FirstItem, (int)SampleEnum.ThirdItem);
                        var name = GetGeneratedNumber();
                        var sample = new SampleDto(randomNumber, (SampleEnum)randomEnum, name);

                        return sample;
                    });
        }

        private string GetGeneratedNumber()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 10) // Length of string = 10
                .Select(s => s[_random.Next(s.Length)]).ToArray());
        }
    }
}
