using System;
using System.Collections.Generic;

namespace GEMAPI.ModelsCORP;

public partial class Usersession
{
    public int Id { get; set; }

    public int? Userid { get; set; }

    public string? Token { get; set; }

    public short? Acknowledged { get; set; }

    public int? Actionpriority { get; set; }

    public DateOnly? Sessionstart { get; set; }

    public DateOnly? Sessionend { get; set; }

    public int? Sessionrecorded { get; set; }

    public string? Sessionrecordurl { get; set; }

    public string? Sessiondescription { get; set; }

    public string? Sessionusername { get; set; }

    public string? Sessionemail { get; set; }

    public string? Sessionfirstname { get; set; }

    public string? Sessionlastname { get; set; }

    public string? Sessionfullname { get; set; }

    public short? Sessioncomplete { get; set; }
}
