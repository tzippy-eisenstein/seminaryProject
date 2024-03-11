using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class TypesOfOccupation1
{
    public int Id { get; set; }

    public int? OccupationTypeId { get; set; }

    public string? Name { get; set; }

    public int? ProfessionTypeId { get; set; }

    public virtual TypesOfOccupation? OccupationType { get; set; }
}
