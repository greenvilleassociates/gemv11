﻿using System;
using System.Collections.Generic;

namespace GEMAPI.ModelsCORP;

public partial class Usergroup
{
    public int Id { get; set; }

    public string? Groupid { get; set; }

    public string? Groupdescription { get; set; }

    public int? Groupownerid { get; set; }

    public string? Groupcompanyid { get; set; }
}
