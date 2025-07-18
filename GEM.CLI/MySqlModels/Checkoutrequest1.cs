using System;
using System.Collections.Generic;

namespace CE.MYSQLMODELS;

public partial class Checkoutrequest1
{
    public int Id { get; set; }

    public int? CartId { get; set; }

    public int? UserId { get; set; }

    public string? RequestDate { get; set; }

    public int? PaymentDetailsId { get; set; }
}
