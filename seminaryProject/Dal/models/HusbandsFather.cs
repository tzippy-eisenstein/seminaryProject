using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class HusbandsFather
{
    public int Id { get; set; }

    public int? PersonId { get; set; }

    public int? PreviousSessionId { get; set; }

    public int? OccupationTypeId { get; set; }

    public int? OccupationId { get; set; }

    public string? Description { get; set; }

    public virtual Person? Person { get; set; }
}
