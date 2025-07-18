using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HPostinstallMessage
{
    public int PostinstallMessageId { get; set; }

    /// <summary>
    /// FK to jos_extensions
    /// </summary>
    public long ExtensionId { get; set; }

    /// <summary>
    /// Lang key for the title
    /// </summary>
    public string TitleKey { get; set; } = null!;

    /// <summary>
    /// Lang key for description
    /// </summary>
    public string DescriptionKey { get; set; } = null!;

    public string ActionKey { get; set; } = null!;

    /// <summary>
    /// Extension holding lang keys
    /// </summary>
    public string LanguageExtension { get; set; } = null!;

    public short LanguageClientId { get; set; }

    /// <summary>
    /// Message type - message, link, action
    /// </summary>
    public string Type { get; set; } = null!;

    /// <summary>
    /// RAD URI to the PHP file containing action method
    /// </summary>
    public string? ActionFile { get; set; }

    /// <summary>
    /// Action method name or URL
    /// </summary>
    public string? Action { get; set; }

    /// <summary>
    /// RAD URI to file holding display condition method
    /// </summary>
    public string? ConditionFile { get; set; }

    /// <summary>
    /// Display condition method, must return boolean
    /// </summary>
    public string? ConditionMethod { get; set; }

    /// <summary>
    /// Version when this message was introduced
    /// </summary>
    public string VersionIntroduced { get; set; } = null!;

    public short Enabled { get; set; }
}
