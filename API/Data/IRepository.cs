namespace Namespace;
public interface IRepository
{
    void Create<T>(T entity) where T:class;
    Task<T> Read<T>(T entity) where T:class;
    void Update<T>(T entity) where T:class;
    void Delete<T>(T entity) where T:class;
    Task<bool> saveAll();
    
}
