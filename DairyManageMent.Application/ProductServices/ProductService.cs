using DairyManagement.Application.Data;
using DairyManagement.Domain.Product;

namespace DairyManagement.Application.ProductServices;

public class ProductService : IProductService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IProductRepository _productRepository;

    public ProductService(IUnitOfWork unitOfWork, IProductRepository productRepository)
    {
        _unitOfWork = unitOfWork;
        _productRepository = productRepository;
    }
    public async Task<Guid> AddProduct(ProductDto productDto)
    {
        if (productDto == null) throw new ArgumentNullException();

        var product = new Product()
        {
            Category = productDto.Category,
            Name = productDto.Name,
            ProductCode = productDto.ProductCode,
            PackagingTypes = productDto.PackagingTypes,
            Volume = productDto.Volume,
            FatPercentage = productDto.FatPercentage,
            ShelfLife = productDto.ShelfLife,
            RequiredMilkAmount = productDto.RequiredMilkAmount,
            IsActive = productDto.IsActive
        };
        var existingProductcode= await _productRepository.GetByProductCode(productDto.ProductCode);
        if (existingProductcode != null)
        {
            throw new Exception("Product code already exists");
        }
            
            
            
        _productRepository.Create(product);
        await _unitOfWork.SaveChanges();
        return product.Id;
    }
}

