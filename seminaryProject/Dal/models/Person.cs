using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class Person
{
    public int Id { get; set; }

    public string? IdentityNumberPassport { get; set; }

    public int? FamilyId { get; set; }

    public string? MaidenName { get; set; }

    public string? Details { get; set; }

    public int? MaritalStatusId { get; set; }

    public int? StreetId { get; set; }

    public string? HouseNumber { get; set; }

    public string? CellPhone { get; set; }

    public string? Email { get; set; }

    public string? Photo { get; set; }

    public string? Comment { get; set; }

    public virtual Family? Family { get; set; }

    public virtual ICollection<Graduate> Graduates { get; set; } = new List<Graduate>();

    public virtual ICollection<HusbandsFather> HusbandsFathers { get; set; } = new List<HusbandsFather>();

    public virtual ICollection<Son> Sons { get; set; } = new List<Son>();

    public virtual Street? Street { get; set; }

    public virtual ICollection<Studentship> Studentships { get; set; } = new List<Studentship>();
}
