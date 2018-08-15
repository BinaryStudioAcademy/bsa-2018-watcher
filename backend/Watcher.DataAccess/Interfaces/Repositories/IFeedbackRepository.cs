using System;
using System.Collections.Generic;
using System.Text;
using Watcher.DataAccess.Entities;

namespace Watcher.DataAccess.Interfaces.Repositories
{
    public interface IFeedbackRepository : IRepository<Feedback, int>
    {
    }
}
