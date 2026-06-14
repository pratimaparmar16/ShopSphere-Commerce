using Microsoft.AspNetCore.Mvc;
using ShopSphere.Application.Interfaces;
using ShopSphere.Application.Services;
using ShopSphere.Web.ViewModels;

namespace ShopSphere.Web.Controllers;

public class ProductController : Controller
{
    private readonly IProductService _productService;

    public ProductController(
        IProductService productService)
    {
        _productService = productService;
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
                CategoryName = p.CategoryName
            }).ToList();

        return View(model);
    }

    public async Task<IActionResult>
    Details(int id)
    {
        var product =
            await _productService.GetProductByIdAsync(id);

        if (product == null)
            return NotFound();

        return View(product);
    }
}