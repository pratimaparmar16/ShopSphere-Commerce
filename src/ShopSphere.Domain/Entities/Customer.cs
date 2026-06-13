using ShopSphere.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSphere.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public ICollection<Order> Orders { get; set; }  = new List<Order>();
    }
}
