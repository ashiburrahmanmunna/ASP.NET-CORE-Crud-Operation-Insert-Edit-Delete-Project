using CrudOperation.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudOperation.Context
{
    public class CrudContext : DbContext
    {
        public CrudContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee>Employee { get; set; }
    }
}
