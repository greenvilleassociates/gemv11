﻿using System;
using System.Collections.Generic;

namespace GEMAPI.ModelsCORP;

public partial class User
{
    public int Id { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string? Username { get; set; }

    public string? Email { get; set; }

    public short? Employee { get; set; }

    public string? Employeeid { get; set; }

    public string? Microsoftid { get; set; }

    public string? Ncrid { get; set; }

    public string? Oracleid { get; set; }

    public string? Azureid { get; set; }

    public string? Plainpassword { get; set; }

    public string? Hashedpassword { get; set; }

    public int? Passwordtype { get; set; }

    public int? Jid { get; set; }

    public string? Profileurl { get; set; }

    public string? Role { get; set; }

    public string? Fullname { get; set; }

    public int? Companyid { get; set; }

    public string? Resettoken { get; set; }

    public DateOnly? Resettokenexpiration { get; set; }

    public int? Userid { get; set; }

    public string? Btn { get; set; }

    public short? Iscertified { get; set; }

    public string? Groupid1 { get; set; }

    public string? Groupid2 { get; set; }

    public string? Groupid3 { get; set; }

    public string? Groupid4 { get; set; }

    public string? Groupid5 { get; set; }

    public string? Somerole { get; set; }
}
