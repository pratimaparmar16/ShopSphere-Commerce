using System.ComponentModel.DataAnnotations;

namespace ShopSphere.Web.ViewModels;

public class CreateProductViewModel
{
    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [Range(1, 1000000)]
    public decimal Price { get; set; }

    [Required]
    [Range(1, 100000)]
    public int StockQuantity { get; set; }

    [Required]
    public int CategoryId { get; set; }
}