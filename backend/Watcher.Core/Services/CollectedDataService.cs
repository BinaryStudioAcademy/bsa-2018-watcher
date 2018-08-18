using System;
using System.Collections.Generic;
using System.Text;
using Watcher.DataAccess;

namespace Watcher.Core.Services
{
    class CollectedDataService
    {
        private DataAccumulatorRepository _repository;
        public CollectedDataService(string ConnectionString, string Database)
        {
            _repository = new DataAccumulatorRepository(ConnectionString, Database);
        }


    }
}
