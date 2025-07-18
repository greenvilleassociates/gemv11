/*using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;

namespace IISExporter.Controllers
{
    [ApiController]
    [Route("api/export")]
    public class IISExporterController : ControllerBase
    {
        private readonly string machineName = Environment.MachineName;
        private readonly string currentDate = DateTime.Now.ToString("yyyyMMdd");
        public readonly string appPoolsPath;
        public readonly string websitesPath;
        public readonly string backupPath;
        private readonly string wdshareDirectory = @"C:\inetpub\wdshare\";
        private readonly string iisBackupsDirectory = @"C:\inetpub\iisbackups\";
        private readonly string vhostDirectory = @"C:\inetpub\vhost\";

        public IISExporterController()
        {
            appPoolsPath = $@"{wdshareDirectory}apppools[{machineName}].xml";
            websitesPath = $@"{wdshareDirectory}websites[{machineName}].xml";
            backupPath = $@"{iisBackupsDirectory}iisbackup[{currentDate}]";
        }

        [HttpGet]
        public IActionResult ExportIIS([FromQuery] int value)
        {
            if (!IsAdministrator())
            {
                return BadRequest("Administrator privileges required. Please run the application as Administrator.");
            }

            switch (value)
            {
                case 1:
                    ExportAppPools();
                    ExportWebsites();
                    BackupIIS();
                    return Ok("IIS configuration export and backup completed.");
                case 0:
                    return Ok(new
                    {
                        AppPoolsFile = appPoolsPath,
                        WebsitesFile = websitesPath,
                        BackupFile = backupPath
                    });
                case 2:
                    EnsureDirectoriesExist();
                    return Ok("Required directories have been created (if missing).");
                default:
                    return BadRequest("Invalid value! Use 1 to export, 0 to return file locations, or 2 to create required directories.");
            }
        }

        private void ExportAppPools()
        {
            ExecuteAppCmd($"list apppool /config /xml > \"{appPoolsPath}\"", "Application pools");
        }

        private void ExportWebsites()
        {
            ExecuteAppCmd($"list site /config /xml > \"{websitesPath}\"", "Websites");
        }

        private void BackupIIS()
        {
            ExecuteAppCmd($"add backup \"IISBACKUP\" > \"{backupPath}\"", "IIS backup");
        }

        private void EnsureDirectoriesExist()
        {
            CreateDirectoryIfMissing(wdshareDirectory);
            CreateDirectoryIfMissing(iisBackupsDirectory);
            CreateDirectoryIfMissing(vhostDirectory); // Newly added!
        }

        private void CreateDirectoryIfMissing(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
                Console.WriteLine($"Created directory: {directoryPath}");
            }
            else
            {
                Console.WriteLine($"Directory already exists: {directoryPath}");
            }
        }

        private void ExecuteAppCmd(string arguments, string operationName)
        {
            Process process = new Process();
            process.StartInfo.FileName = @"C:\Windows\System32\inetsrv\appcmd.exe";
            process.StartInfo.Arguments = arguments;
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.CreateNoWindow = true;

            try
            {
                process.Start();
                process.WaitForExit();
                Console.WriteLine($"{operationName} exported successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error exporting {operationName}: {ex.Message}");
            }
        }

        private bool IsAdministrator()
        {
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }
    }
}
*/