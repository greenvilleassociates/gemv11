using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HPrivacyRequest
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public DateTime RequestedAt { get; set; }

    public short Status { get; set; }

    public string RequestType { get; set; } = null!;

    public string ConfirmToken { get; set; } = null!;

    public DateTime ConfirmTokenCreatedAt { get; set; }
}
