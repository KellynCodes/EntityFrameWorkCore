using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EfCore.DAL.EfCoreSetup
{
    public class ReliconDbFactory : IDesignTimeDbContextFactory<ReliconDbContext>
    {
        public ReliconDbFactory()
        {
        }

        public ReliconDbContext CreateDbContext(string[] args)
        {
            var OptionBuilder = new DbContextOptionsBuilder<ReliconDbContext>();
            var ConnectionString = @"Data Source=DESKTOP-N2LHC09;Initial Catalog=EfCore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            OptionBuilder.UseSqlServer(ConnectionString);
            return new ReliconDbContext(OptionBuilder.Options);
        }
    }
}
