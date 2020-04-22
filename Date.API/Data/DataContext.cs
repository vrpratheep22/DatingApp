using Date.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Date.API.Data
{
    public class DataContext:DbContext
    {
         public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
           public DbSet<Values> Values { get; set; }
    }
}