int number = 49;
Console.WriteLine("Введите целое число");
int user = Convert.ToInt32 (Console.ReadLine());
int result = number%user;
if (result == 0)
{Console.WriteLine("49 делится на это число без остатка");}
else
{Console.WriteLine("Остаток от деления 49 на это число равен ");
Console.WriteLine(result);}