using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class GusersCard
{
    public int Id { get; set; }

    public string? Userid { get; set; }

    public string? Appid { get; set; }

    public string? Cardname { get; set; }

    public string? Cardtype { get; set; }

    public string? Cardnumber { get; set; }

    public string? Cardexpiration { get; set; }

    public string? Cardsecurity { get; set; }

    public DateOnly? Appdate { get; set; }
}
