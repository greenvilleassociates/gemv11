using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gcustomer
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Phone { get; set; }

    public string? Inventoryid { get; set; }

    public string? Customerid { get; set; }

    public string? Oracleid { get; set; }

    public string? Dynamicsid { get; set; }

    public string? Alohaid { get; set; }
}
