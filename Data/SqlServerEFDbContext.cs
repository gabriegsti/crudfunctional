using CrudFucntional.Model;
using Microsoft.EntityFrameworkCore;

namespace CrudFucntional.Data
{
    public class SqlServerEFDbContext : DbContext
    {
        public SqlServerEFDbContext(DbContextOptions<SqlServerEFDbContext> options)
        : base(options)
        {
            
        }

        public DbSet<Product> Product { get; set; }
    }
}