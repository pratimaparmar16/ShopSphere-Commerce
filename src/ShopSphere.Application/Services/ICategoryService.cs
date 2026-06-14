using ShopSphere.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSphere.Application.Services
{
    public interface ICategoryService
    {
        Task<List<ProductDto>> GetAllCategoriesAsync();

        Task<ProductDto?> GetCategoryByIdAsync(int id);

        Task CreateCategoryAsync(CategoryDto categoryDto);
    }
}
