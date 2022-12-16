Console.WriteLine("Задача 1: По двум заданным числам проверять является ли первое квадратом второго");
Console.Write("введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
if(a == b * b)
{
    Console.WriteLine("Первое число является квадратом второго числа");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго числа");
}
