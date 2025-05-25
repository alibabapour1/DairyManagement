using DairyManagement.Domain.Product;

namespace DairyManagement.Application.ProductServices;

public class ProductDto
{
    public string ProductCode { get; set; }
    public string Name { get; set; }
    public Category Category { get; set; }
    public PackagingTypes PackagingTypes { get; set; }
    public decimal Volume { get; set; }
    public decimal FatPercentage { get; set; }
    public int ShelfLife { get; set; }
    public decimal RequiredMilkAmount { get; set; }
    public bool IsActive { get; set; }
}