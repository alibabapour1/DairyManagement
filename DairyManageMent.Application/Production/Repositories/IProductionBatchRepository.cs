using DairyManagement.Application.Abstractions;
using DairyManagement.Domain.BatchRawMaterial;
using DairyManagement.Domain.ProductionBatch;
using DairyManagement.Domain.ProductionStage;

namespace DairyManagement.Application.Production.Repositories;

public interface IProductionBatchRepository : IBaseRepository<ProductionBatch>
{
    
}
public interface IBatchRawMaterialRepository:IBaseRepository<BatchRawMaterial>;
public interface IProductionStageRepository :IBaseRepository<ProductionStage>;
public interface I