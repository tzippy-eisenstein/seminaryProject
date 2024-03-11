using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class Yearbook
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? NumClasses { get; set; }

    public virtual ICollection<Studentship> Studentships { get; set; } = new List<Studentship>();

    public virtual ICollection<SubjectsOfStudyForTheYear> SubjectsOfStudyForTheYears { get; set; } = new List<SubjectsOfStudyForTheYear>();

    public virtual ICollection<YearbookGroupingsPerYear> YearbookGroupingsPerYears { get; set; } = new List<YearbookGroupingsPerYear>();
}
