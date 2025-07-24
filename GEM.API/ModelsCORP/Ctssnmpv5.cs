using System;
using System.Collections.Generic;

namespace GEMAPI.ModelsCORP;

public partial class Ctssnmpv5
{
    public int Id { get; set; }

    public string? TrapId { get; set; }

    public string? Timestamp { get; set; }

    public string? SourceIp { get; set; }

    public string? CommunityString { get; set; }

    public string? SnmpVersion { get; set; }

    public string? EnterpriseOid { get; set; }

    public int? GenericTrapType { get; set; }

    public int? SpecificTrapCode { get; set; }

    public string? AgentAddress { get; set; }

    public string? Varbinds { get; set; }

    public string? Lat { get; set; }

    public string? Long { get; set; }

    public string? Ctsfulllocation { get; set; }

    public string? Vpnid { get; set; }

    public string? User1 { get; set; }

    public string? User2 { get; set; }

    public string? User3 { get; set; }

    public string? User4 { get; set; }

    public string? User5 { get; set; }

    public string? LoopbackSourceIp { get; set; }
}
