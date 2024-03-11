using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class Occupation
{
    public int Id { get; set; }

    public int? OccupationTypeId { get; set; }

    public string? Name { get; set; }

    public virtual TypesOfOccupation? OccupationType { get; set; }

    public virtual ICollection<PlacesOfBusiness> PlacesOfBusinesses { get; set; } = new List<PlacesOfBusiness>();
}
