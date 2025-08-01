using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gdatabase
{
    public int Id { get; set; }

    public int? Siteid { get; set; }

    public int? Parentid { get; set; }

    public string? Description { get; set; }

    public int? Bu { get; set; }

    public int? Branchid { get; set; }

    public string? Ownerid { get; set; }

    public string? Vendorid { get; set; }

    public int? Techcontactid { get; set; }

    public int? Sitecontactid { get; set; }

    public int? Region { get; set; }

    public int? Instanceid { get; set; }
}
