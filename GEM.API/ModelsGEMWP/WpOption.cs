using System;
using System.Collections.Generic;

namespace GEMWP.Models;

public partial class WpOption
{
    public long OptionId { get; set; }

    public string OptionName { get; set; } = null!;

    public string OptionValue { get; set; } = null!;

    public string Autoload { get; set; } = null!;
}
