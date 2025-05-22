using DairyManagement.Domain.RawMilk;

namespace DairyManageMent.Application.RawMilkServices;

public class RawMilkDto
{
    public string SupplierName { get; set; }
    public DateTime ReceiptDate { get; set; }
    public decimal Quantity { get; set; }
    public QualityStatus QualityStatus { get; set; }
    public decimal FatPercentage { get; set; }
    public decimal AcidityDegree { get; set; }
    public decimal Temperature { get; set; } = 4;
    public string Note { get; set; } = string.Empty;

}