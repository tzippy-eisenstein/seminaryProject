using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class YearbookGroupingsPerYear
{
    public int Id { get; set; }

    public int? YearbookProfessionId { get; set; }

    public string? Name { get; set; }

    public int? CirculationAmount { get; set; }

    public virtual Yearbook? YearbookProfession { get; set; }
}
