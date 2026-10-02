using Microsoft.EntityFrameworkCore;
using ProductCatalog.Model.Entities;

namespace ProductCatalog.Model.Context
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}