// Удалить вторую цифру трехзначного числа
Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine()??"0");
Console.WriteLine($"Вторая цифра исчезла: {(a/100)*10+(a%10)}");
