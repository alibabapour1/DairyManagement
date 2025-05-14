

namespace DairyManagement.Domain.InventoryRecord;

public class InventoryRecord
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid BatchId { get; set; }
    public int Quantity { get; set; }
    public DateTime ProductionDate { get; set; }
    public DateTime ExpiryDate { get; set; }
    public string StorageLocation { get; set; }
    public Status Status { get; set; }  

}

public enum Status
{
    InStock =0,
    Reserved = 1,
    Shipped = 2

}