namespace DairyManagement.Application.Helpers;

public static class BatchNumberCreator
{
    public static string Create(string code,DateTime dateTime)
    {
        var timestamp = dateTime.ToString("yyyyMMdd_HHmmss"); 
        var randomSuffix = Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper(); 
        return $"{code}_{timestamp}_{randomSuffix}";
    }
}