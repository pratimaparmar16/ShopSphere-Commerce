using ShopSphere.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSphere.Domain.Entities
{
    public class Payment :BaseEntity
    {
        public string PaymentReference { get; set; } = string.Empty;
        public decimal Amount { get; set; }

        public int OrderId { get; set; }

        public Order? order { get; set; }
    }
}
