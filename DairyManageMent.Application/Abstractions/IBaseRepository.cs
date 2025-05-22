namespace DairyManagement.Application.Abstractions;

public interface IBaseRepository<T>
{
    T Get(Guid id);
    void Create(T  entity);
    void Update(T entity);
    void Delete(Guid id);

}