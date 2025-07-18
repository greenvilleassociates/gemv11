using System;
using System.Collections.Generic;

namespace CE.MYSQLMODELS;

public partial class User
{
    public int Id { get; set; }

    public string? Email { get; set; }

    public string? Username { get; set; }

    public string? DateOfBirth { get; set; }

    public string? Password { get; set; }
}
