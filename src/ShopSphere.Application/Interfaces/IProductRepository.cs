using ShopSphere.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSphere.Application.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<List<Product>> GetProductsByCategoryAsync(int categoryId);
    }
}
