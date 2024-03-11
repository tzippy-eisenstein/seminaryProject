using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class StudySubject
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? SubjectId { get; set; }

    public string? Classification { get; set; }

    public virtual TypesOfStudySubject? Subject { get; set; }

    public virtual ICollection<SubjectsOfStudyForTheYear> SubjectsOfStudyForTheYears { get; set; } = new List<SubjectsOfStudyForTheYear>();
}
