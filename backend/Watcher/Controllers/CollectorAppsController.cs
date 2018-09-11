using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Watcher.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.Core.Interfaces;

    [Route("[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class CollectorAppsController : ControllerBase
    {

        public CollectorAppsController()
        {

        }
        
        [HttpPost, DisableRequestSizeLimit]
        public virtual async Task<ActionResult> CreatedAndSend()
        {
            try
            {
                var file = Request.Form.Files[0];
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
            //long size = files.Length;

            // full path to file in temp location
            var filePath = Path.GetTempFileName();

            //foreach (var formFile in files)
            //{
            //    if (formFile.Length > 0)
            //    {
            //        using (var stream = new FileStream(filePath, FileMode.Create))
            //        {
            //            await formFile.CopyToAsync(stream);
            //        }
            //    }
            //}

            // process uploaded files
            // Don't rely on or trust the FileName property without validation.

            return Ok(true);
        }
    }
}
