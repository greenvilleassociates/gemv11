using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class GitsmDetail
{
    public long Id { get; set; }

    public long? Detailid { get; set; }

    public long? Ticketid { get; set; }

    public string? Linenumber { get; set; }

    public string? Linedetail { get; set; }
}
