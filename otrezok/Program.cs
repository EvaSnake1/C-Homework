int number = new Random().Next(10, 100);
Console.WriteLine("Вот число: ");
Console.WriteLine(number);
int first = number / 10;
int second = number % 10;
Console.Write("Вот его наибольшая цифра ");
if (first > second)
{Console.WriteLine(first);}
else
{Console.WriteLine(second);}