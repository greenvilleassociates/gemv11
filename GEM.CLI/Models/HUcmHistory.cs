using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HUcmHistory
{
    public int VersionId { get; set; }

    public int UcmItemId { get; set; }

    public int UcmTypeId { get; set; }

    /// <summary>
    /// Optional version name
    /// </summary>
    public string VersionNote { get; set; } = null!;

    public DateTime SaveDate { get; set; }

    public int EditorUserId { get; set; }

    /// <summary>
    /// Number of characters in this version.
    /// </summary>
    public int CharacterCount { get; set; }

    /// <summary>
    /// SHA1 hash of the version_data column.
    /// </summary>
    public string Sha1Hash { get; set; } = null!;

    /// <summary>
    /// json-encoded string of version data
    /// </summary>
    public string VersionData { get; set; } = null!;

    /// <summary>
    /// 0=auto delete; 1=keep
    /// </summary>
    public short KeepForever { get; set; }
}
