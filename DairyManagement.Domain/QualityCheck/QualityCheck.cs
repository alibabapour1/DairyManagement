namespace DairyManagement.Domain.QualityCheck;

public class QualityCheck
{
    public Guid Id { get; set; }
    public Guid BatchId{ get; set; }
    public Guid StageRecordId { get; set; }
    public DateTime CheckTime { get; set; }
    public Dictionary<string,string> CheckedParameters { get; set; }
    public Result  Result { get; set; }
    public string Inspector { get; set; }
    public string Notes { get; set; }

}