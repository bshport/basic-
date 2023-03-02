
using System.Text;

// bad
string str = "My name is Bogdan!";
str += "\n";
str += "The last line!";

// good
StringBuilder builder = new StringBuilder();

Console.WriteLine("Length: " + builder.Length);
Console.WriteLine("Capacity: " + builder.Capacity);

builder.Append("My name is Bogdan!");
builder.AppendLine();
builder.AppendLine("The last line!");


Console.WriteLine("Length: " + builder.Length);
Console.WriteLine("Capacity: " + builder.Capacity);

Console.WriteLine("Result:\n" + builder.ToString());
