
//1.Вводиться рядок слів. Вивести слова в зворотньому порядку.
Console.WriteLine("\nTask-1 [Вводиться рядок слів. Вивести слова в зворотньому порядку.]");
Console.WriteLine("Enter the text: ");
string input = Console.ReadLine();
string[] wordss = input.Split(' ');
Array.Reverse(wordss);
string output = string.Join(' ', wordss);
Console.WriteLine($"Reverse text: {output}");

//---------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------

//2.Обрахувати кількість пробілів в рядку, яку введе користувач
Console.WriteLine("\nTask-2 [Обрахувати кількість пробілів в рядку, яку введе користувач]");
Console.Write("Enter the text: ");
string inputt = Console.ReadLine();
int spaces = inputt.Split(' ').Length - 1;
Console.WriteLine("Amount spaces: " + spaces);

//---------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------

//3.Дано текст.Визначте відсоткове відношення малих і великих літер до загальної кількості символів в ньому.

//Console.Write("Enter the text: ");
//string text = Console.ReadLine();
Console.WriteLine("\nTask-3 [Дано текст.Визначте відсоткове відношення малих і великих літер до загальної кількості символів в ньому]");
Console.WriteLine("You can not judge a book by its cover");
string text = "You can not judge a book by its cover";

int totalChars = text.Length;
int uppercaseChars = text.Count(c => char.IsUpper(c));
int lowercaseChars = text.Count(c => char.IsLower(c));
double uppercaseRatio = (double)uppercaseChars / totalChars * 100;
double lowercaseRatio = (double)lowercaseChars / totalChars * 100;

Console.WriteLine("Вiдсоток великих лiтер: " + uppercaseRatio.ToString("0.00") + "%");
Console.WriteLine("Вiдсоток малих лiтер: " + lowercaseRatio.ToString("0.00") + "%");

//---------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------

//4.Написати функцію, яка приймає словосполучення і перетворює його в абревіатуру. 
//Наприклад: cascading style sheets в CSS, об'єктно орієнтоване програмування в ООП.
Console.WriteLine("\nTask-4 [Написати функцію, яка приймає словосполучення і перетворює його в абревіатуру.]");
static string GenerationAbbr(string str)
{
    string[] words = str.Split(' ');
    string abbreviation = "";

    foreach (string word in words)
    {
        abbreviation += word[0];
    }
    return abbreviation.ToUpper();
}
Console.WriteLine(GenerationAbbr("cascading style sheets"));

//---------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------

//5.Користувач вводить слова, поки не буде введено слово з символом крапки вкінці.
//Сформувати з введених слів рядок, розділивши їх комою з пробілом.
Console.WriteLine("\nTask- [Користувач вводить слова, поки не буде введено слово з символом крапки вкінці.\r" +
    "Сформувати з введених слів рядок, розділивши їх комою з пробілом.]");
List<string> words = new List<string>();

while (true)
{
    Console.Write("Введiть текст та в кiнцi поставте крапку: ");
    string word = Console.ReadLine();

    if (word.EndsWith("."))
    {
        break;
    }

    words.Add(word);
}

string result = string.Join(", ", words);

Console.WriteLine("Рядок з введених слiв: " + result);

//---------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------