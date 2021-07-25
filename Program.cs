using ConsoleAppEntityFramework.Models;
using System;

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
        public static void InputData(Customer customer)
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
            context.Dispose();
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
            context.Dispose();
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
            context.Dispose();
        }
        private static void InputData(Log log)
        {
            Console.Write("Input ChatID: ");
            log.ChatID = Console.ReadLine();
            Console.Write("Input command: ");
            log.Command= Console.ReadLine();
            
            context.Logs.Add(log);
            context.SaveChanges();
            context.Dispose();
        }
        #endregion

        #region RemoveData
        private static void RemoveData(Customer customer)
        {
            Console.Write("Input name: ");
            customer.Name = Console.ReadLine();
            Console.Write("Input address: ");
            customer.Address = Console.ReadLine();
            Console.Write("Input balance: ");
            customer.Balance = Int32.Parse(Console.ReadLine());
            Console.Write("Input email: ");
            customer.Email = Console.ReadLine();

            context.Customers.Remove(customer);
            context.SaveChanges();
            context.Dispose();
        }   
        private static void RemoveData(Payment payment)
        {
            Console.Write("Input ChatID: ");
            payment.ChatID = Console.ReadLine();
            Console.Write("Input command: ");
            payment.Command = Console.ReadLine();
            Console.Write("Input Sum: ");
            payment.Sum = Int32.Parse(Console.ReadLine());

            context.Payments.Remove(payment);
            context.SaveChanges();
            context.Dispose();
        }
        private static void RemoveData(Product product)
        {
            Console.Write("Input name: ");
            product.Name = Console.ReadLine();
            Console.Write("Input Category: ");
            product.Category = Console.ReadLine();
            Console.Write("Input price: ");
            product.Price = Int32.Parse(Console.ReadLine());
            Console.Write("Input Discription: ");
            product.Discription = Console.ReadLine();
            
            context.Products.Remove(product);
            context.SaveChanges();
            context.Dispose();
        }
        private static void RemoveData(Log log)
        {
            Console.Write("Input ChatID: ");
            log.ChatID = Console.ReadLine();
            Console.Write("Input command: ");
            log.Command = Console.ReadLine();
 
            context.Logs.Remove(log);
            context.SaveChanges();
            context.Dispose();
        }
        #endregion
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("Введите номер команды");
                Console.WriteLine(
                    "1. Product" + "\n"
                    + "2. Customer" + "\n"
                    + "3. Log" + "\n"
                    + "4. Payment");

                string ChooseNumber = Console.ReadLine();
                string ChooseNumber2;

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
                                RemoveData(product);
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
                                RemoveData(customer);
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
                                RemoveData(log);
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
                                RemoveData(payment);
                                break;
                        }
                        break;
                    default: System.Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
