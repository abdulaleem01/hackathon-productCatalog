using System;
using System.Collections.Generic;

namespace DataLayer.DbEntities;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public string? Description { get; set; }

    public int Price { get; set; }

    public string Date { get; set; } = null!;

    public string Brand { get; set; } = null!;

    public int CategoryTypeId { get; set; }

    public virtual Category CategoryType { get; set; } = null!;

    public virtual ICollection<Specification> Specifications { get; set; } = new List<Specification>();
}
