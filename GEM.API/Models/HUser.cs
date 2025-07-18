using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HUser
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Username { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public short? Block { get; set; }

    public short? SendEmail { get; set; }

    public DateTime? RegisterDate { get; set; }

    public DateTime LastvisitDate { get; set; }

    public string? Activation { get; set; }

    public string? Params { get; set; }

    /// <summary>
    /// Date of last password reset
    /// </summary>
    public DateTime LastResetTime { get; set; }

    /// <summary>
    /// Count of password resets since lastResetTime
    /// </summary>
    public long ResetCount { get; set; }

    public string OtpKey { get; set; } = null!;

    public string? Otep { get; set; }

    /// <summary>
    /// Require user to reset password on next login
    /// </summary>
    public short? RequireReset { get; set; }
}
