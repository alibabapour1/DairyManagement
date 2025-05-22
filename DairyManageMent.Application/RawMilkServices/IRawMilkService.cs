namespace DairyManageMent.Application.RawMilkServices;

public interface IRawMilkService
{
    Guid ReceiveRawMilk(RawMilkDto rawMilkDto);
}