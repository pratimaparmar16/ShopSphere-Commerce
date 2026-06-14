using ShopSphere.Application.DTOs;
using ShopSphere.Application.Interfaces;
using ShopSphere.Domain.Entities;

namespace ShopSphere.Application.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly IUnitOfWork _unitOfWork;

    public ProductService(
        IProductRepository productRepository, IUnitOfWork unitOfWork = null)
    {
        _productRepository = productRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<List<ProductDto>>
        GetAllProductsAsync()
    {
        var products =
            await _productRepository.GetAllAsync();

        return products.Select(p => new ProductDto
        {
            Id = p.Id,
            Name = p.Name,
            Price = p.Price,
            StockQuantity = p.StockQuantity,
            CategoryName =
                p.Category?.Name ?? string.Empty,
            CreatedDate = p.CreatedDate
        }).ToList();
    }

    public async Task<ProductDto?>
        GetProductByIdAsync(int id)
    {
        var product =
            await _productRepository.GetByIdAsync(id);

        if (product == null)
            return null;

        return new ProductDto
        {
            Id = product.Id,
            Name = product.Name,
            Price = product.Price,
            StockQuantity = product.StockQuantity,
            CategoryName =
                product.Category?.Name ?? string.Empty
        };
    }

    public async Task CreateProductAsync(
        ProductDto productDto)
    {
        if (productDto.Price <= 0)
        {
            throw new Exception(
                "Price must be greater than zero.");
        }

        var product = new Product
        {
            Name = productDto.Name,
            Price = productDto.Price,
            StockQuantity = productDto.StockQuantity,
            CategoryId = productDto.CategoryId
        };

        await _productRepository.AddAsync(product);
        await _unitOfWork.SaveChangesAsync();
    }
}