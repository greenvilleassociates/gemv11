using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Ggrid
{
    public int Id { get; set; }

    public string? Geometry { get; set; }

    public int? Gridsite1 { get; set; }

    public int? Gridnode1id { get; set; }

    public int? Gridsite2 { get; set; }

    public int? Gridnode2id { get; set; }

    public int? Gridsite3 { get; set; }

    public int? Gridnode3id { get; set; }

    public int? Gridsite4 { get; set; }

    public int? Gridnode4id { get; set; }

    public int? Gridsite5 { get; set; }

    public int? Gridnode5id { get; set; }

    public int? Gridsite6 { get; set; }

    public int? Gridnode6id { get; set; }

    public int? Drsite1 { get; set; }

    public int? Drnode1id { get; set; }

    public int? Drsite2 { get; set; }

    public int? Drnode2id { get; set; }

    public int? Rootid1 { get; set; }

    public int? Rootid2 { get; set; }

    public string? Vendor { get; set; }

    public string? Vendorid { get; set; }

    public string? Vendorgridname { get; set; }
}
