namespace DairyManagement.Domain.BatchRawMaterial;

public class BatchRawMaterial
{
    public Guid Id { get; set; }
    public Guid BatchId { get; set; }
    public Guid RawMilkId { get; set; }
    public decimal Quantity{ get; set; }
}