using DairyManagement.Application.Abstractions;
using DairyManagement.Domain.Product;

namespace DairyManagement.Application.ProductServices;

public interface IProductRepository:IBaseRepository<Product>
{
    Task<Product?> GetByProductCode(string code);
}