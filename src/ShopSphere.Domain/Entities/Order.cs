using ShopSphere.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSphere.Domain.Entities
{
    public class Order : BaseEntity
    {
        public string OrderNumber { get; set; } = string.Empty;

        public decimal TotalAmount { get; set; }

        public int CustomerId { get; set; }

        public Customer? Customer { get; set; }
    }
}
