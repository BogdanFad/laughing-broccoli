Console.WriteLine("Задача 4: Выяснить явлеется ли число четным? ");
Console.Write("введите число: ");
int a = int.Parse(Console.ReadLine()!);
if (a % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}