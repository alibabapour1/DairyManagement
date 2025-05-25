namespace DairyManagement.Domain.ProductionStage;

public class ProductionStage
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int StageOrder { get; set; }
    public bool IsQualityCheckPoint { get; set; }
    public string RequieredParameters { get; set; }
}