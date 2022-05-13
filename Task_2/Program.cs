// По заданному номеру дня недели вывести его название
Console.WriteLine("Введите номер дня недели");
int a = int.Parse(Console.ReadLine()??"0");
if(a>1&&a<8)
{
    if(a==1) Console.WriteLine("Это понедельник");
    if(a==2) Console.WriteLine("Это вторник");
    if(a==3) Console.WriteLine("Это среда");
    if(a==4) Console.WriteLine("Это четверг");
    if(a==5) Console.WriteLine("Это пятница");
    if(a==6) Console.WriteLine("Это суббота");
    if(a==7) Console.WriteLine("Это воскресенье");
}
else
{
    Console.WriteLine("Дня недели с таким номером не существует!");
}
