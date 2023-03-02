using System;

namespace _03_practice2
{
    class Program
    {
        /*2 - Написати конвертер валют (UAH, USD, EUR, PLN), користувач має можливість ввести кількість валюти в UAH та вибрати в яку він бажає конвертувати величину.*/
        enum Currency
        {
            USD = 1,
            EUR = 2,
            UAN = 3,
            PLN = 4
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of UAN:");
            double uah = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Select the target currency: ");
            Console.WriteLine("1. USD");
            Console.WriteLine("2. EUR");
            Console.WriteLine("3. UAN");
            Console.WriteLine("4. PLN");

            int choice = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            Currency targetCurrency = (Currency)choice;

            switch (targetCurrency)
            {
                case Currency.USD:
                    result = uah / 36.74;
                    Console.WriteLine($"{uah} UAN is equal to {result} USD");
                    break;
                case Currency.EUR:
                    result = uah / 39.28;
                    Console.WriteLine($"{uah} UAN is equal to {result} EUR");
                    break;
                case Currency.UAN:
                    Console.WriteLine($"{uah} UAN is equal to {uah} UAN");
                    break;
                case Currency.PLN:
                    result = uah / 8.26;
                    Console.WriteLine($"{uah} UAN is equal to {result} PLN");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            Console.ReadLine();
        }
    }
}
