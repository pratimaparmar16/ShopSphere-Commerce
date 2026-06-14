using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopSphere.Application.DTOs;
using ShopSphere.Application.Interfaces;
using ShopSphere.Application.Services;
using ShopSphere.Web.ViewModels;

namespace ShopSphere.Web.Controllers;

public class ProductController : Controller
{
    private readonly IProductService _productService;
    private readonly ICategoryService _categoryService;

    public ProductController(
        IProductService productService, ICategoryService categoryService)
    {
        _productService = productService;
        _categoryService = categoryService;
    }

    public async Task<IActionResult> Index()
    {
        var products =
            await _productService.GetAllProductsAsync();

        var model =
            products.Select(p => new ProductViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                CategoryName = p.CategoryName,
                CreatedDate = p.CreatedDate
            }).ToList();

        return View(model);
    }

    public async Task<IActionResult> Details(int id)
    {
        var product =
            await _productService.GetProductByIdAsync(id);

        if (product == null)
            return NotFound();

        return View(product);
    }

    public async Task<IActionResult> Create()
    {
        var categories =
            await _categoryService
                .GetAllCategoriesAsync();

        var model =
            new CreateProductPageViewModel
            {
                Categories =
                    categories.Select(c =>
                        new SelectListItem
                        {
                            Value = c.Id.ToString(),
                            Text = c.Name
                        }).ToList()
            };

        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult>
    Create(CreateProductPageViewModel model)
    {
        if (!ModelState.IsValid)
        {
            var categories =
                await _categoryService
                    .GetAllCategoriesAsync();

            model.Categories =
                categories.Select(c =>
                    new SelectListItem
                    {
                        Value = c.Id.ToString(),
                        Text = c.Name
                    }).ToList();

            return View(model);
        }

        await _productService
            .CreateProductAsync(
                new ProductDto
                {
                    Name = model.Product.Name,
                    Price = model.Product.Price,
                    StockQuantity =
                        model.Product.StockQuantity,
                    CategoryId =
                        model.Product.CategoryId
                });

        return RedirectToAction(nameof(Index));
    }
}