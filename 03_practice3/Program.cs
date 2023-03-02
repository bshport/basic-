using System;

namespace _03_practice3
{
    class Program
    {
        /*3 - Користувач вводить діаметр окружності та вибирає дію, яку бажає виконати:
                    ﻿﻿﻿﻿Отримати радіус кола
                    ﻿﻿﻿﻿Отримати площу кола
﻿﻿﻿﻿                    Отримати периметр кола*/

        enum mathTask
        {
            radious = 1,
            area,
            perimetr
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the diameter of circle in cm:  ");
            double diameter = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Select the math task: ");
            Console.WriteLine("1. Find radious of circle");
            Console.WriteLine("2. Find area of circle");
            Console.WriteLine("3. Find perimeter of circle");
            int choice = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            double radious = diameter / 2;

            mathTask task = (mathTask)choice;

            switch (task)
            {
                case mathTask.radious:
                    Console.WriteLine($"The radious of circle is {radious}");
                    break;
                case mathTask.area:
                    result = Math.PI * radious * radious;
                    Console.WriteLine($"The area of circle is {result}");
                    break;
                case mathTask.perimetr:
                    result = 2 * Math.PI * radious;
                    Console.WriteLine($"The perimeter of circle is {result}");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }


        }
    }
}
