namespace API.Data;

using API.Models;
using Microsoft.EntityFrameworkCore;

public class PersonRepository : IRepository<Person>
{
    private readonly DataContext _context;

    public PersonRepository(DataContext context)
    {
        _context = context;
    }
    public async void Create(Person entity)
    {
        await _context.AddAsync(entity);
    }
    public async Task<List<Person>> ReadAll()
    {
        return await _context.persons.ToListAsync();
    }
    public async Task<Person> Read(int id)
    {
        return await _context.persons.FindAsync(id);
    }
    public void Update(Person entity)
    {
        throw new NotImplementedException();
    }
    public void Delete(Person entity)
    {
        _context.Remove(entity);
    }
    public async Task<bool> saveAll()
    {
        return await _context.SaveChangesAsync() > 0;
    }
}
