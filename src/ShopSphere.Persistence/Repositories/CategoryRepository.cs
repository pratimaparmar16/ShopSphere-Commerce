using Microsoft.EntityFrameworkCore;
using ShopSphere.Application.Interfaces;
using ShopSphere.Domain.Entities;
using ShopSphere.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSphere.Persistence.Repositories
{
    //public class CategoryRepository : Repository<Category>, ICategoryRepository
    //{
    //    public CategoryRepository(ApplicationDbContext context) : base(context) { }

    //    public async Task<Category?> GetCategoryWithProductsAsync(int productId)
    //    {
    //        return await _context.Categories.Where(p => p.Products == categoryId).ToListAsync();
    //    }
    //}
}
