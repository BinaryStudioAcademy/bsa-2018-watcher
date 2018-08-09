using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Watcher.Core.Interfaces;


namespace Watcher.Controllers
{
    //THIS A COMTROLLER FOR TESTING SENDGRID. BEFORE MERGE IT WILL BE DELETED

    [Route("[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private IEmailProvider _emailProvider;

        public EmailController(IEmailProvider emailProvider)
        {
            _emailProvider = emailProvider;
        }

        [HttpGet]
        public async Task SendEmail()
        {
            //enter from email here
            var from = "test@mail.com";

            //enter your subject here
            var subject = "test";

            //enter recipient email here
            var recepient = "recepientTest@mail.com";

            //enter your email message here
            var msg = "msg";

            await _emailProvider.SendMessage(from, subject, recepient, "msg", $"<h1>{msg}</h1>");
        }
    }
}
