using System;
using System.Diagnostics;
using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace IISSiteCreator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IISWebsiteCreator : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateSite([FromBody] string siteName)
        {
            if (string.IsNullOrWhiteSpace(siteName))
            {
                return BadRequest("Site name cannot be empty.");
            }

            string sanitizedSiteName = siteName.Replace(" ", "");
            string sitePath = $@"C:\inetpub\vhost\{sanitizedSiteName}";

            try
            {
                // Create the directory if it doesn't exist
                if (!Directory.Exists(sitePath))
                {
                    Directory.CreateDirectory(sitePath);
                }

                // Create IIS site using PowerShell
                string command = $"New-Website -Name \"{sanitizedSiteName}\" -Port 80 -PhysicalPath \"{sitePath}\" -Force";
                ExecutePowerShellCommand(command);

                return Ok($"IIS site '{sanitizedSiteName}' has been created at {sitePath}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error creating IIS site: {ex.Message}");
            }
        }

        private void ExecutePowerShellCommand(string command)
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "powershell.exe";
                process.StartInfo.Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{command}\"";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
                process.WaitForExit();
            }
        }
    }
}
