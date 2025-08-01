using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Ginventory
{
    public int Id { get; set; }

    public string? Inventoryid { get; set; }

    public int? Inventorytype { get; set; }

    public string? Description { get; set; }

    public string? Serialnumber { get; set; }

    public string? Region { get; set; }

    public string? Insertdate { get; set; }

    public int? Instanceid { get; set; }

    public int? Custid { get; set; }

    public int? Siteid { get; set; }

    public int? Qtyonhand { get; set; }

    public int? Qtyonorder { get; set; }

    public int? Qtybackordered { get; set; }

    public string? Oracleinvid { get; set; }

    public string? Dynamicsinvid { get; set; }

    public string? Ncrinvid { get; set; }

    public string? MgdContractid { get; set; }

    public string? MgdVendor { get; set; }

    public string? MgdActivestatus { get; set; }

    public string? MgdBillingclass { get; set; }

    public string? MgdStartdate { get; set; }

    public string? MgdEnddate { get; set; }

    public string? MgdWarningdate { get; set; }

    public string? MgdNotifyEmail { get; set; }

    public string? MgdNotifySms { get; set; }
}
