using System;

namespace _03_enums
{
    enum Direction { Forward = 1, Right = 2, Left = 3, Backward = 4 };

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose direction:" +
                $"{(int)Direction.Forward} - {Direction.Forward}\n" +
                 $"{(int)Direction.Right} - {Direction.Right}\n" + 
                  $"{(int)Direction.Left} - {Direction.Left}\n" +
                   $"{(int)Direction.Backward} - {Direction.Backward}\n");

            Direction dir = Enum.Parse<Direction>(Console.ReadLine());

            switch (dir)
            {
                case Direction.Forward:
                    Console.WriteLine("We are going forward");
                    break;
                case Direction.Right:
                    Console.WriteLine("We are going right");
                    break;
                case Direction.Left:
                    Console.WriteLine("We are going left");
                    break;
                case Direction.Backward:
                    Console.WriteLine("We are going backward");
                    break;
                default:
                    Console.WriteLine("Invlaid direction");
                    break;
            }

            Console.WriteLine("\nThe end");

        }
    }
}
