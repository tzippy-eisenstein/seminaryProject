using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class Street
{
    public int Id { get; set; }

    public int? NeighborhoodId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Family> Families { get; set; } = new List<Family>();

    public virtual Neighborhood? Neighborhood { get; set; }

    public virtual ICollection<Person> People { get; set; } = new List<Person>();
}
