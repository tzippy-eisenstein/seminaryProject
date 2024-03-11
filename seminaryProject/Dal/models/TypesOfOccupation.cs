using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class TypesOfOccupation
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<Occupation> Occupations { get; set; } = new List<Occupation>();

    public virtual ICollection<TypesOfOccupation1> TypesOfOccupation1s { get; set; } = new List<TypesOfOccupation1>();
}
