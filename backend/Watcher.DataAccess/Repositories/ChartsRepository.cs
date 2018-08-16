using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Watcher.DataAccess.Data;
using Watcher.DataAccess.Entities;
using Watcher.DataAccess.Interfaces.Repositories;

namespace Watcher.DataAccess.Repositories
{
    class ChartsRepository: Repository<Chart,int>, IChartRepository
    {
        public ChartsRepository(WatcherDbContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
   
}
