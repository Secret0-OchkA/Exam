using ExamInfrastructura;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Exam
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                InitializeDatabase(serviceProvider);

                var form1 = serviceProvider.GetRequiredService<Form1>();
                Application.Run(form1);
            }
        }

        static void ConfigureServices(IServiceCollection services)
        { 
            services.AddScoped<Form1>();


            services.AddDbContext<ApplicationDbContext>(options => options
            .UseSqlServer("Server=localhost,1433;Database=applicationdb;User Id=sa;Password=Secretochka2442;Encrypt=false;TrustServerCertificate=true"));
        }

        static void InitializeDatabase(IServiceProvider provider)
        {
            provider.GetRequiredService<ApplicationDbContext>().Database.Migrate();
        }
    }
}