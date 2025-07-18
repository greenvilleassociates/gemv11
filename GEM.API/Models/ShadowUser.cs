using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Shadowuser
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Username { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public DateOnly? Registerdate { get; set; }

    public string? Params { get; set; }

    public DateOnly? Lastvisitdate { get; set; }

    public string? Originatingnode { get; set; }

    public short? Block { get; set; }

    public short? Sendemail { get; set; }

    public string? Activation { get; set; }

    public DateTime? Lastresettime { get; set; }

    public long? Resetcount { get; set; }

    public string? Otpkey { get; set; }

    public string? Otep { get; set; }

    public short? Requirereset { get; set; }
}
