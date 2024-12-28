using Microsoft.EntityFrameworkCore;

namespace DbContextCoreEFCore.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }
    }
}
