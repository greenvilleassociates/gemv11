using System;
using System.Diagnostics;
using System.IO;
using System.ServiceProcess;


public class GEMAPILOGGER : ServiceBase
{
    private string logFilePath = @"c:\greenvillesoftware\GreenvilleController\logs\GEMAPI.log";
    private EventLog eventLog;

    public GEMAPILOGGER()
    {
        // Initialize Event Log
        eventLog = new EventLog();
        if (!EventLog.SourceExists("GEMAPI"))
        {
            EventLog.CreateEventSource("GEMAPISource", "GEMAPILog");
        }
        eventLog.Source = "GEMAPISource";
        eventLog.Log = "GEMAPILog";
    }

    protected override void OnStart(string[] args)
    {
        LogMessage("Greenville GEM API Service started successfully.");
    }

    protected override void OnStop()
    {
        LogMessage("Greenville GEM API Service stopped.");
    }

    protected override void OnCustomCommand(int command)
    {
        LogMessage($"Custom command received: {command}");
    }

    private void LogMessage(string message)
    {
        try
        {
            // Ensure Directory Exists
            string directoryPath = Path.GetDirectoryName(logFilePath);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // Write Log to File
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss}: {message}");
            }

            // Write Log to Event Viewer
            eventLog.WriteEntry(message, EventLogEntryType.Information);
        }
        catch (Exception ex)
        {
            // Handle Exceptions Gracefully
            eventLog.WriteEntry($"Failed to log message: {ex.Message}", EventLogEntryType.Error);
        }
    }
}
