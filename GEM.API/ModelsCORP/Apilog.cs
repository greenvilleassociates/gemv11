﻿using System;
using System.Collections.Generic;

namespace GEMAPI.ModelsCORP;

public partial class Apilog
{
    public int Id { get; set; }

    public string? Descr { get; set; }

    public int? Emplid { get; set; }

    public string? Fullname { get; set; }

    public string? Logdate { get; set; }

    public int? Secpriority { get; set; }

    public string? Noccomments { get; set; }

    public int? NocOpId { get; set; }

    public int? EscalationId { get; set; }

    public string? Triagecasenumber { get; set; }

    public string? Apiurl { get; set; }

    public string? Apirequestdetail { get; set; }
}
