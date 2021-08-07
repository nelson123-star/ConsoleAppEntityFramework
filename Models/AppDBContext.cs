using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using System.Data.SqlClient;

namespace ConsoleAppEntityFramework.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() //: base(options)
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<TGUser> TGUsers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder contextOptionsBuilder)
        {
            //contextOptionsBuilder.UseSqlServer("ConnectionStrings:AppDBContext");
            contextOptionsBuilder.UseSqlServer(@"server = (LocalDB)\MSSQLLocalDB; database = testdatabase; Trusted_Connection = true");
        }
    }   
}
