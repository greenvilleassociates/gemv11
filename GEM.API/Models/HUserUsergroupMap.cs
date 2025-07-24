using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HUserUsergroupMap
{
    /// <summary>
    /// Foreign Key to #__users.id
    /// </summary>
    public long UserId { get; set; }

    /// <summary>
    /// Foreign Key to #__usergroups.id
    /// </summary>
    public long GroupId { get; set; }
}
