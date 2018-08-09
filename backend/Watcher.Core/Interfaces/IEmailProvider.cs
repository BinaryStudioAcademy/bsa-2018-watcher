using System.Collections.Generic;
using System.Threading.Tasks;

namespace Watcher.Core.Interfaces
{
    public interface IEmailProvider
    {
        Task SendMessage(string from, string subject, string recepient, string message, string messageHtml);
    }
}
