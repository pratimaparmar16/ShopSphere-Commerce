using ShopSphere.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSphere.Application.Interfaces
{
    public interface ICategoryRepository
    {
        Task<Category?> GetCategoryWithProductsAsync(int categoryId);
    }
}
