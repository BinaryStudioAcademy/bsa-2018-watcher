﻿using Microsoft.AspNetCore.Http;
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
        private readonly ICollectorAppsService _collectorAppsService;
        public CollectorAppsController(ICollectorAppsService collectorAppsService)
        {
            _collectorAppsService = collectorAppsService;
        }
        
        [HttpPost("uploadApp"), DisableRequestSizeLimit]
        public virtual async Task<ActionResult> UploadFile()
        {
            try
            {
                var file = Request.Form.Files[0];
                if (file.Length > 0)
                {
                    return Ok(await _collectorAppsService.UploadFileToStorage(file));
                }
            }
            catch (System.Exception ex)
            {
                return BadRequest();
            }
            return BadRequest();
        }
    }
}
