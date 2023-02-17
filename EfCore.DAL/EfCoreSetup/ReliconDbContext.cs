using EfCore.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCore.DAL.EfCoreSetup
{
    public class ReliconDbContext : DbContext
    {
        public ReliconDbContext(DbContextOptions<ReliconDbContext> options) : base(options)
        {

        }

       public DbSet<User> Users { get; set; }
    }
}
