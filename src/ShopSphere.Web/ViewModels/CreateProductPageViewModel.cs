using Microsoft.AspNetCore.Mvc.Rendering;

namespace ShopSphere.Web.ViewModels;

public class CreateProductPageViewModel
{
    public CreateProductViewModel Product { get; set; }
        = new();

    public List<SelectListItem> Categories
    { get; set; }
        = new();
}