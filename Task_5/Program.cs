// Показать вторую цифру трехзначного числа
Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine()??"0");
Console.WriteLine($"Вторая цифра этого числа: {(a/10)%10}");
