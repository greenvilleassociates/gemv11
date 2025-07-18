using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gapp
{
    public int Id { get; set; }

    public string? Appid { get; set; }

    public string? Appdescription { get; set; }

    public int? Apptype { get; set; }

    public int? Appregion { get; set; }

    public string? Dbmstype { get; set; }

    public string? Dbmsvendor { get; set; }

    public string? Dbmstopology { get; set; }

    public int? Gridid { get; set; }

    public string? Targetgrid { get; set; }

    public string? Targetgeometry { get; set; }

    public int? Targetgridid { get; set; }

    public int? Iscompliant { get; set; }

}
