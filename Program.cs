﻿using ConsoleAppEntityFramework.Models;
using System;

namespace ConsoleAppEntityFramework
{
    class Program
    {
        #region inputData
        public void inputData(Customer customer)
        {
            Console.Write("Input name: ");
            customer.Name = Console.ReadLine();
            Console.Write("Input address: ");
            customer.Address = Console.ReadLine();
            Console.Write("Input balance: ");
            customer.Balance = Int32.Parse(Console.ReadLine());
            Console.Write("Input email: ");
            customer.Email = Console.ReadLine();

            using (AppDBContext context = new AppDBContext())
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }
        private void inputData(Payment payment)
        {
            Console.Write("Input ChatID: ");
            payment.ChatID = Console.ReadLine();
            Console.Write("Input command: ");
            payment.Command = Console.ReadLine();
            Console.Write("Input Sum: ");
            payment.Sum = Int32.Parse(Console.ReadLine());
            
            using (AppDBContext context = new AppDBContext())
            {
                context.Payments.Add(payment);
                context.SaveChanges();
            }
        }
        private void inputData(Product product)
        {
            Console.Write("Input name: ");
            product.Name = Console.ReadLine();
            Console.Write("Input Category: ");
            product.Category = Console.ReadLine();
            Console.Write("Input price: ");
            product.Price = Int32.Parse(Console.ReadLine());
            Console.Write("Input Discription: ");
            product.Discription = Console.ReadLine();

            using (AppDBContext context = new AppDBContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
        private void inputData(Log log)
        {
            Console.Write("Input ChatID: ");
            log.ChatID = Console.ReadLine();
            Console.Write("Input command: ");
            log.Command= Console.ReadLine();


            using (AppDBContext context = new AppDBContext())
            {
                context.Logs.Add(log);
                context.SaveChanges();
            }
        }
        #endregion

        #region removeData
        private void removeData(Customer customer)
        {
            Console.Write("Input name: ");
            customer.Name = Console.ReadLine();
            Console.Write("Input address: ");
            customer.Address = Console.ReadLine();
            Console.Write("Input balance: ");
            customer.Balance = Int32.Parse(Console.ReadLine());
            Console.Write("Input email: ");
            customer.Email = Console.ReadLine();

            using (AppDBContext context = new AppDBContext())
            {
                context.Customers.Remove(customer);
                context.SaveChanges();
            }
        }
        private void removeData(Payment payment)
        {
            Console.Write("Input ChatID: ");
            payment.ChatID = Console.ReadLine();
            Console.Write("Input command: ");
            payment.Command = Console.ReadLine();
            Console.Write("Input Sum: ");
            payment.Sum = Int32.Parse(Console.ReadLine());

            using (AppDBContext context = new AppDBContext())
            {
                context.Payments.Remove(payment);
                context.SaveChanges();
            }
        }
        private void removeData(Product product)
        {
            Console.Write("Input name: ");
            product.Name = Console.ReadLine();
            Console.Write("Input Category: ");
            product.Category = Console.ReadLine();
            Console.Write("Input price: ");
            product.Price = Int32.Parse(Console.ReadLine());
            Console.Write("Input Discription: ");
            product.Discription = Console.ReadLine();

            using (AppDBContext context = new AppDBContext())
            {
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }
        private void removeData(Log log)
        {
            Console.Write("Input ChatID: ");
            log.ChatID = Console.ReadLine();
            Console.Write("Input command: ");
            log.Command = Console.ReadLine();


            using (AppDBContext context = new AppDBContext())
            {
                context.Logs.Remove(log);
                context.SaveChanges();
            }
        }
        #endregion
        static void Main(string[] args)
        {
            Program program = new Program();
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
                                program.inputData(product);
                                break;
                            case "2":
                                program.removeData(product);
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
                                program.inputData(customer);
                                break;
                            case "2":
                                program.removeData(customer);
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
                                program.inputData(log);
                                break;
                            case "2":
                                program.removeData(log);
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
                                program.inputData(payment);
                                break;
                            case "2":
                                program.removeData(payment);
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
