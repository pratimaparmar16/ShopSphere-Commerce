using Microsoft.EntityFrameworkCore;
using ShopSphere.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSphere.Persistence.Context
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}
