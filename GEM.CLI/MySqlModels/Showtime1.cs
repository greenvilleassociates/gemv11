using System;
using System.Collections.Generic;

namespace CE.MYSQLMODELS;

public partial class Showtime1
{
    public int Id { get; set; }

    public string? StartTime { get; set; }

    public int? MovieId { get; set; }

    public int? Capacity { get; set; }

    public int? TicketsSold { get; set; }

    public int? TicketsAvailable { get; set; }
}
