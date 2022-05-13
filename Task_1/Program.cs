// По двум заданным числам проверить - является ли первое квадратом второго
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Ввдите второе число");
int b = int.Parse(Console.ReadLine()??"0");
if(a==b*b)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}
