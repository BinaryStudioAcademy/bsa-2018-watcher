namespace Watcher.Core.Services
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Security.Cryptography;

    using AutoMapper;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.SignalR;

    using Watcher.Core.Hubs;
    using Watcher.Common.Enums;
    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.Core.Interfaces;
    using Watcher.DataAccess.Entities;
    using Watcher.DataAccess.Interfaces;
    using Microsoft.AspNetCore.Http;

    public class CollectorAppsService : ICollectorAppsService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        private readonly IEmailProvider _emailProvider;
        private readonly IFileStorageProvider _fileStorageProvider;
        public CollectorAppsService(IUnitOfWork uow,
                                    IMapper mapper,
                                    IEmailProvider emailProvider,
                                    IFileStorageProvider fileStorageProvider)
        {
            _uow = uow;
            _mapper = mapper;
            _emailProvider = emailProvider;
            _fileStorageProvider = fileStorageProvider;
        }

        public async Task<string> UploadFileToStorage(IFormFile file)
        {
            return await _fileStorageProvider.UploadFormFileWithNameAsync(file);
        }

    }
}
