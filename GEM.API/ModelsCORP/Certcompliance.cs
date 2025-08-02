using System;
using System.Collections.Generic;

namespace GEMAPI.ModelsCORP;

public partial class Certcompliance
{
    public int Id { get; set; }

    public int? Certificateid { get; set; }

    public string? Certificatename { get; set; }

    public int? Bu { get; set; }

    public int? Branchid { get; set; }

    public int? Managerid { get; set; }

    public int? Regionid { get; set; }

    public int? Companyid { get; set; }

    public DateOnly? Compliancedate { get; set; }

    public DateOnly? Warningdate { get; set; }

    public short? Warningacknowledged { get; set; }

    public int? Responsiblepartyid { get; set; }

    public string? Complianceid { get; set; }

    public string? Projectid { get; set; }

    public string? Customerid { get; set; }

    public string? Vendorid { get; set; }

    public string? Compsource { get; set; }
}
