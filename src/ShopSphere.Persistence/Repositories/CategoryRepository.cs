using Microsoft.EntityFrameworkCore;
using ShopSphere.Application.Interfaces;
using ShopSphere.Domain.Entities;
using ShopSphere.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSphere.Persistence.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext context) : base(context) { }

        public async Task<List<Category>> GetAllCategories()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category?> GetCategoryWithProductsAsync(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
