using ConsoleAppEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityFramework.Controllers
{
    class RemoveController
    {
        public  AppDBContext _context;

        public RemoveController(AppDBContext context)
        {
            _context = context;
        }

        #region RemoveData
        public  void RemoveData(Customer customer)
        {
            Console.Write("Input name: ");
            customer.Name = Console.ReadLine();
            Console.Write("Input address: ");
            customer.Address = Console.ReadLine();
            Console.Write("Input balance: ");
            customer.Balance = Int32.Parse(Console.ReadLine());
            Console.Write("Input email: ");
            customer.Email = Console.ReadLine();

            var custom1 = _context.Customers.FirstOrDefault(cust => cust.Name == customer.Name);

            if (custom1.Name == customer.Name)
            {
                _context.Entry(custom1).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
            else Console.WriteLine("Таких данных нет в базе");

        }
        public  void RemoveData(Payment payment)
        {
            Console.Write("Input ChatID: ");
            payment.ChatID = Console.ReadLine();
            Console.Write("Input command: ");
            payment.Command = Console.ReadLine();
            Console.Write("Input Sum: ");
            payment.Sum = Int32.Parse(Console.ReadLine());

            var paym1 = _context.Payments.FirstOrDefault(p => p.Sum == payment.Sum);

            if (paym1.Sum == payment.Sum)
            {
                _context.Entry(paym1).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                _context.Payments.Remove(payment);
                _context.SaveChanges();
            }
            else Console.WriteLine("Таких данных нет в базе");
        }
        public  void RemoveData(Product product)
        {
            Console.Write("Input name: ");
            product.Name = Console.ReadLine();
            Console.Write("Input Category: ");
            product.Category = Console.ReadLine();
            Console.Write("Input price: ");
            product.Price = Int32.Parse(Console.ReadLine());
            Console.Write("Input Discription: ");
            product.Discription = Console.ReadLine();

            var prod1 = _context.Products.FirstOrDefault(products => products.Name == product.Name);

            if (prod1.Name == product.Name)
            {
                _context.Entry(prod1).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                _context.Products.Remove(prod1);
                _context.SaveChanges();
            }
            else Console.WriteLine("Таких данных нет в базе");
        }
        public  void RemoveData(Log log)
        {
            Console.Write("Input ChatID: ");
            log.ChatID = Console.ReadLine();
            Console.Write("Input command: ");
            log.Command = Console.ReadLine();

            var log1 = _context.Logs.FirstOrDefault(logs => logs.Command == log.Command);

            if (log1.Command == log.Command)
            {
                _context.Entry(log1).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                _context.Logs.Remove(log);
                _context.SaveChanges();
            }
            else Console.WriteLine("Таких данных нет в базе");
        }
        #endregion
    }
}
