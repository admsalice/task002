// Напишите пограмму, которая 
// 1. на вход выдает два числа и
// 2. выдает, какое число больше,а какое меньше
// 3. вывод результата

// Пример
// a=5; b=7 -> max=7
// a=2; b=10 -> max=10
// a=-9; b=-3 -> max=-3

Console.WriteLine("Введите 2 числа");
Console.WriteLine("Чтобы узнать какое больше,а какое меньше");
Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine("Число" + number1 + "большее" );
    Console.Write("Число" + number2 + "меньшее");
}
else if (number1 == number2)
{
    Console.WriteLine("Число" + number1 + "ровно числу" + number2);
}
else
{
    Console.WriteLine("Число" + number2 + "большее");
    Console.Write("Число" + number1 + "меньшее");
}
