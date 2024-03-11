using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class Graduate
{
    public int Id { get; set; }

    public int? PersonId { get; set; }

    public DateTime? DateOfMarriage { get; set; }

    public int? HusbandFamilyId { get; set; }

    public int? OccupationId { get; set; }

    public DateTime? DateStartingWork { get; set; }

    public virtual Person? Person { get; set; }
}
