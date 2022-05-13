// Выяснить - кратно ли число заданному, если нет - вывести остаток
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Ввдите второе число");
int b = int.Parse(Console.ReadLine()??"0");
if(a%b==0)
{
    Console.WriteLine($"{a} кратно {b}");
}
else
{
    Console.WriteLine($"Остаток от деления: {a%b}");
}
