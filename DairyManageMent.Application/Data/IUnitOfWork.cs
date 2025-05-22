namespace DairyManagement.Application.Data;

public interface IUnitOfWork
{
    Task SaveChanges();
}