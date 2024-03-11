using System;
using System.Collections.Generic;

namespace Dal.models;

public partial class PlacesOfBusiness
{
    public int Id { get; set; }

    public int? BusinessId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual Occupation? Business { get; set; }
}
