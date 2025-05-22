using DairyManagement.Application.Helpers;
using DairyManagement.Domain.RawMilk;

namespace DairyManageMent.Application.RawMilkServices;

public class RawMilkService : IRawMilkService
{
    private readonly IRawMilkRepository _repository;

    public Guid ReceiveRawMilk(RawMilkDto rawMilkDto)
    {
        if (rawMilkDto ==null)
        {
            throw new NullReferenceException("the inputs can't be empty");
        }

        var batchNumber = BatchNumberCreator.Create("RM", rawMilkDto.ReceiptDate);

        var rawMilk = new RawMilk()
        {
            Temperature = rawMilkDto.Temperature,
            ReceiptDate = rawMilkDto.ReceiptDate,
            AcidityDegree = rawMilkDto.AcidityDegree,
            BatchNumber = batchNumber,
            Notes = rawMilkDto.Note,
            FatPercentage = rawMilkDto.FatPercentage,
            QualityStatus = rawMilkDto.QualityStatus,
            Quantity = rawMilkDto.Quantity,
            SupplierName = rawMilkDto.SupplierName


        };
        if (rawMilkDto.Temperature >10 )
        {
            rawMilk.QualityStatus = QualityStatus.RequiresSpecialReview;
        }

        if (rawMilkDto.AcidityDegree >= 18 )
            rawMilk.QualityStatus= QualityStatus.Rejected;





    }
}