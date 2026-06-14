using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSphere.Application.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public string CategoryName { get; set; } = string.Empty;

        public int CategoryId { get; set; }

        public DateTime CreatedDate {  get; set; }
    }
}
