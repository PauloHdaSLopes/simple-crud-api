using API.Data;

namespace Namespace;
public class ApiRepository : IRepository
{
    private readonly DataContext _context;

    public ApiRepository(DataContext context)
    {
        _context = context;
    }
    public void Create<T>(T entity) where T : class
    {
        _context.Add(entity);
    }
    public Task<T> Read<T>(int id) where T : class
    {
        
    }
    public void Update<T>(T entity) where T : class
    {
        throw new NotImplementedException();
    }
    public void Delete<T>(T entity) where T : class
    {
        _context.Remove(entity);
    }
    public async Task<bool> saveAll()
    {
        return await _context.SaveChangesAsync() > 0;
    }
}
