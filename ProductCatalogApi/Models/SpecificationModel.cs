using System;
namespace Models
{
    public class SpecificationModel
    {
        public int SpecificationId { get; set; }

        public string Key { get; set; } = null!;

        public string Value { get; set; } = null!;

        public int ProductId { get; set; }
    }
}

