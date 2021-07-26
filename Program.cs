using ConsoleAppEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppEntityFramework
{
    class Program
    {
        static AppDBContext context = null;

        static Program()
        {
            context = new AppDBContext();
        }
        #region InputData
        private static void InputData(Customer customer)
        {
            Console.Write("Input name: ");
            customer.Name = Console.ReadLine();
            Console.Write("Input address: ");
            customer.Address = Console.ReadLine();
            Console.Write("Input balance: ");
            customer.Balance = Int32.Parse(Console.ReadLine());
            Console.Write("Input email: ");
            customer.Email = Console.ReadLine();
            
            context.Customers.Add(customer);
            context.SaveChanges();
        }
        private static void InputData(Payment payment)
        {
            Console.Write("Input ChatID: ");
            payment.ChatID = Console.ReadLine();
            Console.Write("Input command: ");
            payment.Command = Console.ReadLine();
            Console.Write("Input Sum: ");
            payment.Sum = Int32.Parse(Console.ReadLine());

            context.Payments.Add(payment);
            context.SaveChanges();
        }
        private static void InputData(Product product)
        {
            Console.Write("Input name: ");
            product.Name = Console.ReadLine();
            Console.Write("Input Category: ");
            product.Category = Console.ReadLine();
            Console.Write("Input price: ");
            product.Price = Int32.Parse(Console.ReadLine());
            Console.Write("Input Discription: ");
            product.Discription = Console.ReadLine();

            context.Products.Add(product);
            context.SaveChanges();
        }
        private static void InputData(Log log)
        {
            Console.Write("Input ChatID: ");
            log.ChatID = Console.ReadLine();
            Console.Write("Input command: ");
            log.Command= Console.ReadLine();
            
            context.Logs.Add(log);
            context.SaveChanges();
        }
        #endregion

        #region _RemoveData
        private static void _RemoveData(Customer customer)
        {
            Console.Write("Input name: ");
            customer.Name = Console.ReadLine();
            Console.Write("Input address: ");
            customer.Address = Console.ReadLine();
            Console.Write("Input balance: ");
            customer.Balance = Int32.Parse(Console.ReadLine());
            Console.Write("Input email: ");
            customer.Email = Console.ReadLine();

            var custom1 = context.Customers.FirstOrDefault(cust => cust.Name == customer.Name);

            if (custom1.Name == customer.Name)
            {
                context.Entry(custom1).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                context.Customers.Remove(customer);
                context.SaveChanges();
            }
            else Console.WriteLine("Таких данных нет в базе");

        }
        private static void _RemoveData(Payment payment)
        {
            Console.Write("Input ChatID: ");
            payment.ChatID = Console.ReadLine();
            Console.Write("Input command: ");
            payment.Command = Console.ReadLine();
            Console.Write("Input Sum: ");
            payment.Sum = Int32.Parse(Console.ReadLine());

            var paym1 = context.Payments.FirstOrDefault(p => p.Sum == payment.Sum);

            if (paym1.Sum == payment.Sum)
            {
                context.Entry(paym1).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                context.Payments.Remove(payment);
                context.SaveChanges();
            }
            else Console.WriteLine("Таких данных нет в базе");
        }
        private static void _RemoveData(Product product)
        {
            Console.Write("Input name: ");
            product.Name = Console.ReadLine();
            Console.Write("Input Category: ");
            product.Category = Console.ReadLine();
            Console.Write("Input price: ");
            product.Price = Int32.Parse(Console.ReadLine());
            Console.Write("Input Discription: ");
            product.Discription = Console.ReadLine();

            var prod1 = context.Products.FirstOrDefault(products => products.Name == product.Name);

            if (prod1.Name == product.Name)
            {
                context.Entry(prod1).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                context.Products.Remove(prod1);
                context.SaveChanges();
            }
            else Console.WriteLine("Таких данных нет в базе");
        }
        private static void _RemoveData(Log log)
        {
            Console.Write("Input ChatID: ");
            log.ChatID = Console.ReadLine();
            Console.Write("Input command: ");
            log.Command = Console.ReadLine();

            var log1 = context.Logs.FirstOrDefault(logs => logs.Command == log.Command);

            if (log1.Command == log.Command)
            {
                context.Entry(log1).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                context.Logs.Remove(log);
                context.SaveChanges();
            }
            else Console.WriteLine("Таких данных нет в базе");
        }
        #endregion
        static void Main(string[] args)
        {
             string ChooseNumber = null;
             string ChooseNumber2 = null;
            while (true)
            {
                Console.WriteLine("Введите номер команды");
                Console.WriteLine(
                    "1. Product" + "\n"
                    + "2. Customer" + "\n"
                    + "3. Log" + "\n"
                    + "4. Payment" + "\n"
                    + "5. Выход из программы");

                ChooseNumber = Console.ReadLine();

                switch (ChooseNumber)
                {
                    case "1":
                        Product product = new Product();
                        Console.WriteLine("1. Ввод данных" + "\n" + "2. Удаление данных");
                        ChooseNumber2 = Console.ReadLine();
                        switch (ChooseNumber2)
                        {
                            case "1":
                                InputData(product);
                                break;
                            case "2":
                                _RemoveData(product);
                                break;
                        }
                        break;
                    case "2":
                        Customer customer= new Customer();
                        Console.WriteLine("1. Ввод данных" + "\n" + "2. Удаление данных");
                        ChooseNumber2 = Console.ReadLine();
                        switch (ChooseNumber2)
                        {
                            case "1":
                                InputData(customer);
                                break;
                            case "2":
                                _RemoveData(customer);
                                break;
                        }
                        break;

                    case "3":
                        Log log = new Log();
                        Console.WriteLine("1. Ввод данных" + "\n" + "2. Удаление данных");
                        ChooseNumber2 = Console.ReadLine();
                        switch (ChooseNumber2)
                        {
                            case "1":
                                InputData(log);
                                break;
                            case "2":
                                _RemoveData(log);
                                break;
                        }
                        break;
                    case "4":
                        Payment payment = new Payment();
                        Console.WriteLine("1. Ввод данных" + "\n" + "2. Удаление данных");
                        ChooseNumber2 = Console.ReadLine();
                        switch (ChooseNumber2)
                        {
                            case "1":
                                InputData(payment);
                                break;
                            case "2":
                                _RemoveData(payment);
                                break;
                        }
                        break;
                    case "5":
                        context.Dispose();
                        System.Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
