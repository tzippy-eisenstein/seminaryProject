using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class Studentship
{
    public int Id { get; set; }

    public int? StudentId { get; set; }

    public int? YearbookId { get; set; }

    public int? ClassNumber { get; set; }

    public virtual Person? Student { get; set; }

    public virtual Yearbook? Yearbook { get; set; }
}
