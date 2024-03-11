using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class Neighborhood
{
    public int Id { get; set; }

    public int? CityId { get; set; }

    public string? Name { get; set; }

    public virtual City? City { get; set; }

    public virtual ICollection<Street> Streets { get; set; } = new List<Street>();
}
