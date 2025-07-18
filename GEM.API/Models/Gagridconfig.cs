using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gagridconfig
{
    public long Id { get; set; }

    public string? Regionid { get; set; }

    public int? Gridinstance { get; set; }

    public int? Nodeid { get; set; }

    public string? Nodename { get; set; }

    public string? Sqllocaltype { get; set; }

    public string? Nodedbms1 { get; set; }

    public string? Nodedbm1sid { get; set; }

    public string? Node1ip { get; set; }

    public string? Node1port { get; set; }

    public string? Nodedbms2 { get; set; }

    public string? Nodedbm2sid { get; set; }

    public string? Node2ip { get; set; }

    public string? Node2port { get; set; }

    public string? Nodedbms3 { get; set; }

    public string? Nodedbm3sid { get; set; }

    public string? Node3ip { get; set; }

    public string? Node3port { get; set; }
}
