using ShopSphere.Application.DTOs;
using ShopSphere.Application.Interfaces;
using ShopSphere.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSphere.Application.Services
{
    public class CategoryService :ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Task CreateCategoryAsync(CategoryDto categoryDto)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto?> GetCategoryByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CategoryDto>> GetAllCategoriesAsync()
        {
            var category = await _categoryRepository.GetAllCategories();

            return category.Select(p => new CategoryDto
            {
                Id = p.Id,
                Name = p.Name
            }).ToList();
        }
    }
}
