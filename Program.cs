using ConsoleAppEntityFramework.Controllers;
using ConsoleAppEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppEntityFramework
{
    class Program
    {
        static AppDBContext context = null;
        static InputController input = null;
        static RemoveController remove = null;

        static Program()
        {
            context = new AppDBContext();
            input = new InputController(context);
            remove = new RemoveController(context);
        }

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
                                input.InputData(product);
                                break;
                            case "2":
                                remove.RemoveData(product);
                                break;
                        }
                        break;
                    case "2":
                        Customer customer = new Customer();
                        Console.WriteLine("1. Ввод данных" + "\n" + "2. Удаление данных");
                        ChooseNumber2 = Console.ReadLine();
                        switch (ChooseNumber2)
                        {
                            case "1":
                                input.InputData(customer);
                                break;
                            case "2":
                                remove.RemoveData(customer);
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
                                input.InputData(log);
                                break;
                            case "2":
                                remove.RemoveData(log);
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
                                input.InputData(payment);
                                break;
                            case "2":
                                remove.RemoveData(payment);
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
