using System;
using System.Collections.Generic;

namespace GEMAPI.ModelsCORP;

public partial class Learningmodule
{
    public int Id { get; set; }

    public string? Cataloguesku { get; set; }

    public string? Description { get; set; }

    public string? Videourl { get; set; }

    public string? Author { get; set; }

    public short? Authorcomp { get; set; }

    public string? Authorcontact { get; set; }

    public short? Emprequired { get; set; }

    public int? Uisection { get; set; }
}
