using System;

namespace test_project
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nк - лк спроб на пароль"); 

              int triesCount = 5;
              string password = "qwerty";
              string UserInput;

              for (int i = 0; i < triesCount; i++)
              {
                  Console.Write("Введiть пароль: ");
                  UserInput = Console.ReadLine();
                  if(UserInput == password)
                  {
                      Console.WriteLine("Пароль правильний!");
                      Console.WriteLine("Secrets");
                      break;
                  }
                  else
                  {
                      Console.WriteLine("Неправильний пароль!");
                      Console.WriteLine("У вас  залишилось спроб: " + (triesCount - i - 1));
                  }
              }



            Console.WriteLine("вкладання грошей в банк під відсоток"); 

            float money;
            int years;
            int percent;

            Console.Write("Введiть суму грошей, внесених на вклад: ");
            money = Convert.ToSingle(Console.ReadLine());

            Console.Write("На скiльки рокiв вiдкритий вклад? :  ");
            years = Convert.ToInt32(Console.ReadLine());

            Console.Write("Пiд який вiдсоток? :  ");
            percent = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < years; i++)
            {
                money += money / 100 + percent;
                Console.WriteLine("В цьому роцi, у Вас: " + money);
                Console.ReadKey();
            }




            Console.WriteLine("\nГра - бій гравця з ворогом"); 

            Console.WriteLine("Game - Battle");
            Console.Write("Enter the amount of health for player: ");
            int playerHealth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the amount of damage for player: ");
            int playerDamage = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the amount of health for enemy: ");
            int enemyHealth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the amount of damage for enemy: ");
            int enemyDamage = Convert.ToInt32(Console.ReadLine());

            while (playerHealth > 0 && enemyHealth > 0)
            {
                playerHealth -= enemyDamage;
                enemyHealth -= playerDamage;

                Console.WriteLine(playerHealth + " - Player Health");
                Console.WriteLine(enemyHealth + " - Enemy Health");
            }
             
            if (playerHealth <=0 && enemyHealth <= 0)
            {
                Console.WriteLine("\nGame result: DRAW!");
            }
            else if (enemyHealth <= 0)
            {
                Console.WriteLine("\nGame result: PLAYER WIN!");
            }
            else if (playerHealth <= 0)
            {
                Console.WriteLine("\nGame result: ENEMY WIN!");
            }

            /*Random rand = new Random();
            int value;
            while (true)
            {
                value = rand.Next(0, 10);
                Console.WriteLine($"\nRandom value is: {value}");
                Console.ReadKey();
            }*/

            Console.WriteLine("\n Малюємо лінію!");

            Console.WriteLine("Введіть символ лінії: ");
            char symbol = Console.ReadKey().KeyChar; 

            Console.WriteLine("\nВведіть довжину лінії: ");
            int length = Convert.ToInt32(Console.ReadLine()); 

            for (int i = 0; i < length; i++)
            {
                Console.Write(symbol); 
            }
            Console.ReadLine();
        }
    }
}
