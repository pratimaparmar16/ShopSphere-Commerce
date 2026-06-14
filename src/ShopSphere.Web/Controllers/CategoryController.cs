using Microsoft.AspNetCore.Mvc;
using ShopSphere.Application.Services;
using ShopSphere.Web.ViewModels;

namespace ShopSphere.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _CategoryService;

        public CategoryController(
            ICategoryService CategoryService)
        {
            _CategoryService = CategoryService;
        }

        public async Task<IActionResult> Index()
        {
            var Categorys =
                await _CategoryService.GetAllCategoriesAsync();

            //var model =
            //    Categorys.Select(p => new CategoryViewModel
            //    {
            //        Id = p.Id,
            //        Name = p.Name,
            //        Price = p.Price,
            //        CategoryName = p.CategoryName
            //    }).ToList();

            return View();
        }
    }
}