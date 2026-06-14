using ShopSphere.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSphere.Application.Services
{
    public interface IProductService
    {
        Task<List<ProductDto>> GetAllProductsAsync();

        Task<ProductDto?> GetProductByIdAsync(int id);

        Task CreateProductAsync(ProductDto productDto);
    }
}
