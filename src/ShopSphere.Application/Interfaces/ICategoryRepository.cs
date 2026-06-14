using ShopSphere.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSphere.Application.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<Category?> GetCategoryWithProductsAsync(int categoryId);
        Task<List<Category>> GetAllCategories();
    }
}
