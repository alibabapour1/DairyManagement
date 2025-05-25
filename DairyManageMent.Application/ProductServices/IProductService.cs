namespace DairyManagement.Application.ProductServices;

public interface IProductService
{
    Task<Guid> AddProduct(ProductDto product);
}