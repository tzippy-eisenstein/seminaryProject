using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class TypesOfFamily
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Family> Families { get; set; } = new List<Family>();
}
