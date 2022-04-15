using DumpRazorWeb.Model;
using Microsoft.EntityFrameworkCore;

namespace DumpRazorWeb.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
    
    
}
