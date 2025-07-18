using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HFinderLink
{
    public int LinkId { get; set; }

    public string Url { get; set; } = null!;

    public string Route { get; set; } = null!;

    public string? Title { get; set; }

    public string? Description { get; set; }

    public DateTime Indexdate { get; set; }

    public string? Md5sum { get; set; }

    public short Published { get; set; }

    public int? State { get; set; }

    public int? Access { get; set; }

    public string Language { get; set; } = null!;

    public DateTime PublishStartDate { get; set; }

    public DateTime PublishEndDate { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public decimal ListPrice { get; set; }

    public decimal SalePrice { get; set; }

    public long TypeId { get; set; }

    public byte[] Object { get; set; } = null!;
}
