/*using System;
using System.Diagnostics;
using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProcessIdController : ControllerBase
    {
        public int GridManagerController()
        {
            WriteProcessIdToFile();
            return 0;
        }

        private void WriteProcessIdToFile()
        {
            try
            {
                int processId = Process.GetCurrentProcess().Id;
                string filePath = "/var/run/gridmanager.pid"; // Standard directory for PID files on Linux
                System.IO.File.WriteAllText(filePath, processId.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing PID file: {ex.Message}");
            }
        }

        [HttpGet]
        public string GetStatus()
        {
            return "GridManager is running.";
        }
    }
}
*/