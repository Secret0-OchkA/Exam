using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ExamInfrastructura
{
    public class ApplicationDbContextDesignFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            string connectionString = "Server=localhost,1433;Database=applicationdb;User Id=sa;Password=Secretochka2442;Encrypt=false;TrustServerCertificate=true";
            DbContextOptionsBuilder<ApplicationDbContext> contextOptionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            contextOptionsBuilder
                .UseSqlServer(connectionString);

            return new ApplicationDbContext(contextOptionsBuilder.Options);
        }
    }
}
