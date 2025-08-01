using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Grightofway
{
    public int Id { get; set; }

    public int? Rowid { get; set; }

    public int? Rowtype { get; set; }

    public string? Description { get; set; }

    public string? Inventoryid { get; set; }
}
