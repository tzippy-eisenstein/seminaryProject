using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class Son
{
    public int Id { get; set; }

    public int? PersonId { get; set; }

    public int? OriginalResidenceId { get; set; }

    public int? OccupationTypeId { get; set; }

    public int? PositionId { get; set; }

    public virtual Person? Person { get; set; }
}
