// Найти третью цифру числа или сообщить, что ее нет
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()??"0");
if (a>99)
{
    while (a>1000)
    {
        a=a/10;
    }
    Console.WriteLine($"Третья цифра этого числа: {a%10}");
}
else
{
    Console.WriteLine("В этом числе нет третьей цифры");
}
