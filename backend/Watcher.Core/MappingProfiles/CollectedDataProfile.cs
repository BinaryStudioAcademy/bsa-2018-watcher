using AutoMapper;
using DataAccumulator.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Watcher.Common.Dtos;
using Watcher.DataAccess.Entities;

namespace Watcher.Core.MappingProfiles
{
    public class CollectedDataProfile: Profile
    {
        public CollectedDataProfile()
        {
            CreateMap<CollectedData, CollectedData>();

            CreateMap<CollectedData, CollectedDataDto>();
        }
    }
}
