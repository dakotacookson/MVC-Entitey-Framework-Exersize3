using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class TESTCONTEXT : DbContext
    {
        public TESTCONTEXT(DbContextOptions<TESTCONTEXT> options) : base(options)
        {
        }

        public DbSet<Test> Id { get; set; }
        public DbSet<Test> TestName { get; set; }
    }
}