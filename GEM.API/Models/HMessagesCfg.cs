using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HMessagesCfg
{
    public long UserId { get; set; }

    public string CfgName { get; set; } = null!;

    public string CfgValue { get; set; } = null!;
}
