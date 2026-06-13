using ShopSphere.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSphere.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<Product> Products { get; set; }
        = new List<Product>();
    }
}
