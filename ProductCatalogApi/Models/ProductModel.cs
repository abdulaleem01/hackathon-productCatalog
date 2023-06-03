using System;
namespace Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; } = null!;

        public string? Description { get; set; }

        public int Price { get; set; }

        public string Date { get; set; } = null!;

        public string Brand { get; set; } = null!;

        public int CategoryTypeId { get; set; }
    }
}

