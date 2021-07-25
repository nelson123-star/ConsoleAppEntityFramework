using ConsoleAppEntityFramework.Models;
using System;

namespace ConsoleAppEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using(AppDBContext context = new AppDBContext())
            {
                Customer customer = new Customer();
                
                context.Customers.Add(new Customer{Name = "Vladimir", Address = "Irkutsk", Balance = 40000, Email = "vladimir@mail.ru"  });
                context.Logs.Add(new Log { ChatID = "jlkasfdhgjkahdf", Command = "perevel", DataTime = DateTime.Now });

                context.SaveChanges();

            }
            Console.WriteLine("Hello World!");
        }
    }
}
