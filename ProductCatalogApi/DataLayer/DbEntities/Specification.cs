using System;
using System.Collections.Generic;

namespace DataLayer.DbEntities;

public partial class Specification
{
    public int SpecificationId { get; set; }

    public string Key { get; set; } = null!;

    public string Value { get; set; } = null!;

    public int ProductId { get; set; }

    public virtual Product Product { get; set; } = null!;
}
