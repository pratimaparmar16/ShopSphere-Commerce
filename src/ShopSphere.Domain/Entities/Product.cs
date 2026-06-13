using ShopSphere.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSphere.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public int CategoryId { get; set; }

        public Category? Category { get; set; }
    }
}
