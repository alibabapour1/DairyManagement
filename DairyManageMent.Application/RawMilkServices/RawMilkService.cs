using DairyManagement.Application.Data;
using DairyManagement.Application.Helpers;
using DairyManagement.Domain.RawMilk;

namespace DairyManageMent.Application.RawMilkServices;

public class RawMilkService : IRawMilkService
{
    private readonly IRawMilkRepository _repository;
    private readonly IUnitOfWork _unitOfWork;

    public RawMilkService(IUnitOfWork unitOfWork, IRawMilkRepository repository)
    {
        _unitOfWork = unitOfWork;
        _repository = repository;
    }

    public async Task<Guid> ReceiveRawMilk(RawMilkDto rawMilkDto)
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

        _repository.Create(rawMilk);
        await _unitOfWork.SaveChanges();

        return rawMilk.Id;





    }
}