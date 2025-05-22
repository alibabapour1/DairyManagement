using DairyManagement.Domain.Product;

namespace DairyManagement.Domain.ProductionBatch;

public class ProductionBatch
{
    public Guid Id { get; set; }
    public string BatchNumber { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int PlannedQuantity { get; set; }
    public int? ActualQuantity { get; set; }
    public Status Status { get; set; }

    public Product.Product Product { get; set; }
    public Guid ProductId { get; set; }
    public ICollection<BatchRawMaterial.BatchRawMaterial> UsedBatchRawMaterials { get; set; }
    public ICollection<ProductionStageRecord.ProductionStageRecord> ProductionStageRecords { get; set; }


}