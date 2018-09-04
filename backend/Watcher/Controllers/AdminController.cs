namespace Watcher.Controllers
{
    using System;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    using Watcher.Common.Enums;
    using Watcher.Core.Interfaces;

    public class AdminController : ControllerBase
    {
        private readonly IFileStorageProvider _fileStorageProvider;

        public AdminController(IFileStorageProvider fileStorageProvider)
        {
            _fileStorageProvider = fileStorageProvider;
        }

        [HttpPost("CollectorInstaller")]
        [DisableRequestSizeLimit]
        public async Task<IActionResult> UploadCollectorInstallerFile([FromForm] IFormFile file, OperatingSystems system)
        {
            if (file == null || file.Length == 0)
                return Content("file not selected");

            try
            {
                var url = await _fileStorageProvider.UploadFormFileAsync(file, system);
                return Ok(url);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
