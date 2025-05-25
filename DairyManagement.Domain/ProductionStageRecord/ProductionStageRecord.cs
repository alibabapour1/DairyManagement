namespace DairyManagement.Domain.ProductionStageRecord;

public class ProductionStageRecord
{
    public Guid Id { get; set; }
    public Guid BatchId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string ResponsibleOperator { get; set; }
    public string ParameterValues { get; set; }
    public Status Status { get; set; }
    public string Notes { get; set; }

    public Guid StageId { get; set; }
    public ProductionStage.ProductionStage ProductionStage { get; set; }

}