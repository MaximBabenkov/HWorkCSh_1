// Выяснить - является ли число четным
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()??"0");
if(a%2==0)
{
    Console.WriteLine("Это число - четное");
}
else
{
    Console.WriteLine("Это число - нечетное");
}
