namespace Watcher.Core.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    //using AutoMapper;

    //using Microsoft.EntityFrameworkCore;

    using Watcher.Common.Dtos;
    using Watcher.Common.Errors;
    using Watcher.Common.Requests;
    using Watcher.Core.Interfaces;

    public class SamplesService : ISamplesService
    {
        //public SamplesService(IUnitOfWork uow, IMapper mapper)
        //    : base(uow, mapper)
        //{
        //}

        public async Task<IEnumerable<SampleDto>> GetAllEntitiesAsync()
        {
            throw new Exception();
        }

        public async Task<SampleDto> GetEntityByIdAsync(int id)
        {
            throw new Exception();

        }

        public async Task<SampleDto> CreateEntityAsync(SampleRequest request)
        {
            throw new Exception();

        }

        public async Task<bool> UpdateEntityByIdAsync(SampleRequest request, int id)
        {
            throw new Exception();
        }

        public async Task<bool> DeleteEntityByIdAsync(int id)
        {
            throw new Exception();
        }
    }
}
