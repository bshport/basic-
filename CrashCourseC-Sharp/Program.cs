using System;

namespace CrashCourseC_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello World");

            //Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello World");

            Console.Title = "First C# Application";

            /*Escape sequences:
             *   \n - new line
             *   \t - tabulation
             *   \" - "
             *   \' - '
             *   \\ - \
             */

            //read data from console 
            Console.Write("Hello, please write you login and press Enter: ");
            string login = Console.ReadLine();
            Console.WriteLine($"Yeaah, your login is: {login}");

        }
    }
}
