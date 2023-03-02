using System;

namespace data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Types

            //simple types:
            //integers (short: 2, int: 4, long: 8)
            //floating-point: (float: 4, double: 8, decimal: 16)

            //symbols:
            //char, string

            //logic:
            //boll

            Console.WriteLine("\tLiterals");
            Console.WriteLine(125.5.GetType());

            //interpolation: "$...{expression}..."
            Console.WriteLine($"Value: 123, type: {123.GetType()}");
            Console.WriteLine($"Value: 123L, type: {123L.GetType()}");
            Console.WriteLine($"Value: 45.6, type: {45.6.GetType()}");
            Console.WriteLine($"Value: 45.6F, type: {45.6F.GetType()}");
            Console.WriteLine($"Value: 45.6M, type: {45.6M.GetType()}");
            Console.WriteLine($"Value: 10954695985485, type: {10954695985485.GetType()}");
            Console.WriteLine($"Value: '!', type: {'!'.GetType()}");
            Console.WriteLine($"Value: \"DobryiDen:)\", type: {"DobryiDen".GetType()}");
            Console.WriteLine($"Value: true, type: {true.GetType()}");
            //Console.WriteLine($"Value: -0.001237, type: {-0.001237.GetType()}");  error ?

            //create variable: type name  = value;
            //variable naming: camelCase

            //Example: door
            //float width = 125.5F;
            //float height = 275.5F;
            //string color = "Dark-brown";
            //string material = "Wood";
            //bool isOpen = true;

            //Console.WriteLine("\n");
            //Console.WriteLine($"Info about our door: \nsize: {width}x{height}cm, \ncolor: {color}, \nmaterial: {material},\n" + $"Status: {isOpen}.");

            ////-----------ariphmetic operation: + - * / %

            //float area = width * height;
            //Console.WriteLine($"Area of door in cm: {area} cm^2,\nArea of door in metrs: {area / 10000} m^2.");

            //double a = 5 / 2; //2
            //double b = 5 / 2.0; //2.5
            //double c = 5 / (double)2; //2.5
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            //-----------logic operation: == > >= =< < !=
            // combine logic conditions with: &&(and), ||(or)
            //opossite: !

            Console.WriteLine($"Operator >: {10 > 5}");
            Console.WriteLine($"Operator !=: {9 != 9}");
            Console.WriteLine($"Operator &&: {10 > 5 && 7 > 0}");
            Console.WriteLine($"Operator ||: {5 > 6 || 7 > 0}");


            //if statement
            Console.Write("Введiть номер місяця: ");
            int month = int.Parse(Console.ReadLine());

            if (month >= 1 && month >= 12)
            {
                Console.WriteLine("Month correct!");
            }
            else Console.WriteLine("Month incorrect");
            
        }
    }
}
