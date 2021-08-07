using ConsoleAppEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityFramework.Controllers
{
    class InputController
    {
        private  AppDBContext _context;
        public InputController(AppDBContext context)
        {
            _context = context;
        }
        #region InputData
        public  void InputData(Customer customer)
        {
            Console.Write("Input name: ");
            customer.Name = Console.ReadLine();
            Console.Write("Input address: ");
            customer.Address = Console.ReadLine();
            Console.Write("Input balance: ");
            customer.Balance = Int32.Parse(Console.ReadLine());
            Console.Write("Input email: ");
            customer.Email = Console.ReadLine();

            _context.Customers.Add(customer);
            _context.SaveChanges();
        }
        public  void InputData(Payment payment)
        {
            Console.Write("Input ChatID: ");
            payment.ChatID = Console.ReadLine();
            Console.Write("Input command: ");
            payment.Command = Console.ReadLine();
            Console.Write("Input Sum: ");
            payment.Sum = Int32.Parse(Console.ReadLine());

            _context.Payments.Add(payment);
            _context.SaveChanges();
        }
        public  void InputData(Product product)
        {
            Console.Write("Input name: ");
            product.Name = Console.ReadLine();
            Console.Write("Input Category: ");
            product.Category = Console.ReadLine();
            Console.Write("Input price: ");
            product.Price = Int32.Parse(Console.ReadLine());
            Console.Write("Input Discription: ");
            product.Discription = Console.ReadLine();

            _context.Products.Add(product);
            _context.SaveChanges();
        }
        public  void InputData(Log log)
        {
            Console.Write("Input ChatID: ");
            log.ChatID = Console.ReadLine();
            Console.Write("Input command: ");
            log.Command = Console.ReadLine();

            _context.Logs.Add(log);
            _context.SaveChanges();
        }
        #endregion
    }
}
