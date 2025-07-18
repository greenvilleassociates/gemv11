using System;
using System.Collections.Generic;

namespace GEMAPI.ModelsCORP;

public partial class Certification
{
    public int Id { get; set; }

    public short? Employee { get; set; }

    public string? Employeeid { get; set; }

    public string? Certname { get; set; }

    public string? Revision { get; set; }

    public DateOnly? Certdate { get; set; }

    public DateOnly? Revisedate { get; set; }

    public int? Bu { get; set; }

    public string? Comments { get; set; }

    public string? Certificationbloburl { get; set; }

    public string? Certlevel { get; set; }

    public int? Userid { get; set; }

    public string? Fullname { get; set; }

    public int? Certype { get; set; }

    public int? Employeeidasinteger { get; set; }

    public int? Companyid { get; set; }

    public string? EmployeeEmail { get; set; }

    public int? Regionid { get; set; }

    public int? Managerid { get; set; }

    public int? Branchid { get; set; }

    //public string? Employeeemail { get; set; }
}
