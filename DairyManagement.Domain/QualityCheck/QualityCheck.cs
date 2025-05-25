namespace DairyManagement.Domain.QualityCheck;

public class QualityCheck
{
    public Guid Id { get; set; }
    public DateTime CheckTime { get; set; }
    public string CheckedParameters { get; set; }
    public Result  Result { get; set; }
    public string Inspector { get; set; }
    public string Notes { get; set; }


    public ProductionBatch.ProductionBatch ProductionBatch { get; set; }
    public Guid BatchId { get; set; }

    public ProductionStageRecord.ProductionStageRecord ProductionStageRecord { get; set; }
    public Guid StageRecordId { get; set; }

}