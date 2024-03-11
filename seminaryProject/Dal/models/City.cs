using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class City
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Neighborhood> Neighborhoods { get; set; } = new List<Neighborhood>();
}
