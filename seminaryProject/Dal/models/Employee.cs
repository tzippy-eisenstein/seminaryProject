using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class Employee
{
    public int Id { get; set; }

    public int? EmployeeTypeId { get; set; }

    public string? Description { get; set; }

    public string? EducationData { get; set; }

    public virtual TypesOfOccupation? EmployeeType { get; set; }
}
