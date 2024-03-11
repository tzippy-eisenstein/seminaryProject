using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class TypesOfStudySubject
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<StudySubject> StudySubjects { get; set; } = new List<StudySubject>();
}
