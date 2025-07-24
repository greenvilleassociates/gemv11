using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HFieldsValue
{
    public long FieldId { get; set; }

    public string ItemId { get; set; } = null!;

    public string? Value { get; set; }
}
