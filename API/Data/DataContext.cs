namespace API.Data;

using API.Models;
using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options):base(options)
    {
        
    }
    public DbSet<Person> persons {get; set;}
}
