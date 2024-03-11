using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class SubjectsOfStudyForTheYear
{
    public int Id { get; set; }

    public int? YearbookId { get; set; }

    public int? AcademicYear { get; set; }

    public int? SubjectId { get; set; }

    public int? WeeklyHours { get; set; }

    public string? Groupings { get; set; }

    public virtual StudySubject? Subject { get; set; }

    public virtual Yearbook? Yearbook { get; set; }
}
