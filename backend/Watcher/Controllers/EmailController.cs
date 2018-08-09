using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Watcher.Core.Interfaces;
using Watcher.Core.Providers;

namespace Watcher.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private IEmailProvider _emailProvider;

        public EmailController(IEmailProvider emailProvider)
        {
            _emailProvider = emailProvider;
        }

        public async Task SendEmail()
        {
            await _emailProvider.SendMessage("tt@gmail.com", "Try", new List<string>(){ "t@gmail.com" }, "msg", "msgHtml");
        }
    }
}
