using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Guser
{
    public int Id { get; set; }

    public int? Jid { get; set; }

    public string? Userid { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string? Username { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? Region { get; set; }

    public string? Postal { get; set; }

    public string? Country { get; set; }

    public string? Faxnumber { get; set; }

    public string? Cardnumber { get; set; }

    public string? Expirecard { get; set; }

    public string? Securitycard { get; set; }

    public string? Nameoncard { get; set; }

    public string? Cardaddress1 { get; set; }

    public string? Cardaddress2 { get; set; }

    public string? Cardzip { get; set; }

    public string? Cardregion { get; set; }

    public string? Cardcity { get; set; }

    public string? Cardcountry { get; set; }

    public string? Firstproduct { get; set; }

    public string? Registrationdate { get; set; }

    public string? Ssduns { get; set; }

    public string? Secondproduct { get; set; }

    public string? Keytype { get; set; }

    public string? Cellphone { get; set; }

    public string? Corporatename { get; set; }

    public string? Fullname { get; set; }
}
