using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class Family
{
    public int Id { get; set; }

    public string? FamilyName { get; set; }

    public string? FatherIdentityPassport { get; set; }

    public string? MotherIdentityPassport { get; set; }

    public string? HomePhone { get; set; }

    public int? StreetId { get; set; }

    public string? HouseNumber { get; set; }

    public string? Note { get; set; }

    public int? FamilyTypeId { get; set; }

    public virtual TypesOfFamily? FamilyType { get; set; }

    public virtual ICollection<Person> People { get; set; } = new List<Person>();

    public virtual Street? Street { get; set; }
}
