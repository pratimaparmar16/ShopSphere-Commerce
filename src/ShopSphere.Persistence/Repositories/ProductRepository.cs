using Microsoft.EntityFrameworkCore;
using ShopSphere.Application.Interfaces;
using ShopSphere.Domain.Entities;
using ShopSphere.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSphere.Persistence.Repositories
{
    public class ProductRepository :Repository<Product>,IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context) { }

        public async Task<List<Product>> GetProductsByCategoryAsync(int categoryId)
        {
            return await _context.Products.Where(p => p.CategoryId == categoryId).ToListAsync();
        }
    }
}
