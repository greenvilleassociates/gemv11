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

    public string? Targetgeometry { get; set; }

    public string? Targetgrid { get; set; }

    public int? Targetgridid { get; set; }

    public int? Iscompliant { get; set; }

    public string? Licenseid { get; set; }

    public int? Vendorid { get; set; }

    public string? Versionnumber { get; set; }

    public int? Totalseats { get; set; }

    public DateOnly? Licenseexpiration { get; set; }

    public int? Licensetype { get; set; }

    public int? Legalcontactid { get; set; }

    public string? Whynoncompliant { get; set; }
}
