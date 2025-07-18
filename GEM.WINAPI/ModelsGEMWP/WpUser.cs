﻿using System;
using System.Collections.Generic;

namespace GEMWP.Models;

public partial class WpUser
{
    public long Id { get; set; }

    public string UserLogin { get; set; } = null!;

    public string UserPass { get; set; } = null!;

    public string UserNicename { get; set; } = null!;

    public string UserEmail { get; set; } = null!;

    public string UserUrl { get; set; } = null!;

    public DateTime UserRegistered { get; set; }

    public string UserActivationKey { get; set; } = null!;

    public int UserStatus { get; set; }

    public string DisplayName { get; set; } = null!;
}
