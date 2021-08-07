using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using System.Data.SqlClient;
using Microsoft.Extensions;
using Microsoft.Extensions.Configuration;


namespace ConsoleAppEntityFramework.Models
{
    public class AppDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<TGUser> TGUsers { get; set; }

        IConfiguration AppConfiguration { get; set; }
        ConfigurationBuilder builder = (ConfigurationBuilder)new ConfigurationBuilder().AddJsonFile("appsettings.json");
        

        protected override void OnConfiguring(DbContextOptionsBuilder contextOptionsBuilder)
        {
            AppConfiguration = builder.Build();
            string configuration = AppConfiguration["ConnectionStrings:AppDBContext"];
            //var configdefault = configuration.GetSection().Value;
            //contextOptionsBuilder.UseSqlServer(iconfiguration.GetConnectionString"ConnectionStrings:AppDBContext");
            //contextOptionsBuilder.UseSqlServer(@"server = (LocalDB)\MSSQLLocalDB; database = testdatabase; Trusted_Connection = true");
            contextOptionsBuilder.UseSqlServer(configuration);

        }
    }   
}
