using System;

namespace _02_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Завдання:
            1 - Користувач вводить поточну дату (рік, місяць, день), відобразити її у форматі "DD/MM/YYYY".
            2 - Користувач вводить 2 сторони прямокутника. Вивести на екран його периметр та площу.
            3 - Користувач вводить радіус кола, програма повинна знайти його площу.
            4 - Користувач вводить час в секундах, відобразити його у вигляді: HH:MM:SS.
            5 - Користувач вводить рік, відобразити скільки днів в цьому році.*/

            Console.WriteLine("Завдання 1");
            Console.Write("Введiть поточний рiк: ");
                string year = Console.ReadLine();
            Console.Write("Введiть поточний мiсяць: ");
                string month = Console.ReadLine();
            Console.Write("Введiть поточний день мiсяця: ");
                string day = Console.ReadLine();
            Console.WriteLine($"\n{year}/{month}/{day}.");

            Console.WriteLine("Завдання 2");
            Console.Write("Введiть першу сторону прямокутника в см: ");
                double first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введiть другу сторону прямокутника в см: ");
                double second = Convert.ToDouble(Console.ReadLine());
             double perimetr = 2 * (first + second);
             double area = first * second;
            Console.WriteLine($"\nЗнайдений периметр прямокутника дорiвнює: {perimetr} cm.");
            Console.WriteLine($"\nЗнайдена площа прямокутника дорiвнює: {area} cm.");

            Console.WriteLine("Завдання 3");
            Console.Write("Введiть радіус кола в см: ");
                double radius = Convert.ToDouble(Console.ReadLine());
                double area_circle = Math.PI * radius * radius;
            Console.WriteLine($"\nЗнайдена площа кола дорiвнює: {area_circle} cm.");

            Console.WriteLine("Завдання 4");
            Console.Write("Введiть час в секундах: ");
            int timeScanner = Convert.ToInt32(Console.ReadLine());
                int hours = timeScanner / 3600;
                int minutes = (timeScanner % 3600) / 60;
                int seconds = (timeScanner % 3600) % 60;
            Console.WriteLine($"\nРезультат форматування: {hours}-HH/{minutes}-MM/{seconds}-SS.");

        }
    }
}
