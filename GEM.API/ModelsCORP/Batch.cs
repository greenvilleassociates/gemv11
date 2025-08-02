using System;
using System.Collections.Generic;

namespace GEMAPI.ModelsCORP;

public partial class Batch
{
    public int Id { get; set; }

    public string? Batchname { get; set; }

    public string? Filelocationpath { get; set; }

    public int? Batchtype { get; set; }

    public int? Batchstatus { get; set; }

    public DateOnly? Batchstart { get; set; }

    public DateOnly? Batchend { get; set; }

    public double? Qtystart { get; set; }

    public double? Qtyend { get; set; }

    public double? Qtyexpected { get; set; }

    public double? Qtyactual { get; set; }

    public double? Qtyerror { get; set; }

    public double? Qty { get; set; }
}
