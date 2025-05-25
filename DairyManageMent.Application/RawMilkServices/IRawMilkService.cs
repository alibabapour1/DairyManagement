namespace DairyManageMent.Application.RawMilkServices;

public interface IRawMilkService
{
    Task<Guid> ReceiveRawMilk(RawMilkDto rawMilkDto);
}