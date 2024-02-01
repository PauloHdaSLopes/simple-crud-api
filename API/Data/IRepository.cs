namespace API.Data;
public interface IRepository<T> where T : class
{
    void Create(T entity);
    Task<List<T>> ReadAll();
    Task<T> Read(int id);
    void Update(T entity);
    void Delete(T entity);
    Task<bool> saveAll();
}
