using System;

namespace _05_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Завдання:
            //1.Показати лінію на екран.Символ та довжину лінії повинен вводити користувач.

          Console.Write("\nВведiть символ лiнiї: ");
            char symb = Console.ReadKey().KeyChar;

            Console.Write("\nВведiть довжину лiнiї: ");
            int len = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < len; i++)
            {
                Console.Write(symb);
            }
            Console.ReadKey();

            //2.Написати гру «Вгадай число». 
            //    Програма «загадує» випадковим чином число, після чого користувач повинен вгадати його. 
            //    Вкінці потрібнго відобразити кількість спроб, яку було використано.

            Random random = new Random();
            int randomNumber = random.Next(1, 31);
            Console.WriteLine("Вгадайте число від 1 до 30");

            int numberOfAttempts = 0;
            int guess = 0;
            while (guess != randomNumber)
            {
                Console.Write("Введіть число: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out guess))
                {
                    numberOfAttempts++;

                    if (guess < randomNumber)
                    {
                        Console.WriteLine("Загадане число більше");
                    }
                    else if (guess > randomNumber)
                    {
                        Console.WriteLine("Загадане число менше");
                    }
                    else
                    {
                        Console.WriteLine($"Ви вгадали число за {numberOfAttempts} спроб");
                    }
                }
                else
                {
                    Console.WriteLine("Введіть коректне число");
                }
            }

            Console.ReadLine();

            //Створити масив із 20 - ти цілих чисел та заповнити його випадковими значеннями від 0 до 100.Додати меню, яке дозволить користувачу виконати наступне:
            //-обрахувати суму чисел в масиві
            //-відсортувати масив
            //- знайти кількість парних значень
            //- *знайти максимальний елемент

            int[] nums = new int[20];
            Random rand = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(0, 101);
            }

            Console.WriteLine("Програмою було створено масив на 20 елементiв " +
                "\r\nта заповнено його рандомнини елементами, " +
                "\r\nнижче вивiд його елементiв по порядку:\n ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"Елемент №{i}: {nums[i]}");
            }

            while (true)
            {
                Console.WriteLine("\nДалi, виберiть опцiю:");
                Console.WriteLine("1. Обчислити суму чисел в масивi");
                Console.WriteLine("2. Вiдсортувати масив");
                Console.WriteLine("3. Знайти кiлькiсть парних значень");
                Console.WriteLine("4. Знайти максимальний елемент");
                Console.WriteLine("5. Вийти з програми");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    int sum = 0;
                    foreach (int element in nums)
                    {
                        sum += element;
                    }
                    Console.WriteLine("Сума чисел в масивi: " + sum);
                }
                else if (choice == "2")
                {
                    Array.Sort(nums);
                    Console.WriteLine("Масив вiдсортовано.");

                    for (int i = 0; i < nums.Length; i++)
                    {
                        Console.WriteLine($"Елемент №{i}: {nums[i]}");
                    }
                }
                else if (choice == "3")
                {
                    int count = 0;
                    foreach (int element in nums)
                    {
                        if (element % 2 == 0)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine("Кiлькiсть парних значень в масивi: " + count);
                }
                else if (choice == "4")
                {
                    int max = nums[0];
                    for (int i = 1; i < nums.Length; i++)
                    {
                        if (nums[i] > max)
                        {
                            max = nums[i];
                        }
                    }
                    Console.WriteLine("Максимальний елемент в масивi: " + max);
                }
                else if (choice == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Вибрано невiрну опцiю.");
                }


            }
        }
    }
}
