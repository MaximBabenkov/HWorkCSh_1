// Показать четные числа от 1 до N
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()??"0");
int start = 1;
while(start<=a)
{
    if(start%2==0)
    {
        Console.Write($" {start}");
        start++;
    }
    else
    {
        start++;
    }
}
