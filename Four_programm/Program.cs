Console.WriteLine("Задача 2: По заданному номеру дня недели вывести его название ");
Console.Write("Введите номер дня недели: ");
int DayNumber = int.Parse(Console.ReadLine());
if (DayNumber == 1) 
{
    Console.WriteLine("Понедельник");
}
if (DayNumber == 2) 
{
    Console.WriteLine("Вторник");
}
if (DayNumber == 3) 
{
    Console.WriteLine("Среда");
}
if (DayNumber == 4) 
{
    Console.WriteLine("Четверг");
}
if (DayNumber == 5) 
{
    Console.WriteLine("Пятница");
}
if (DayNumber == 6) 
{
    Console.WriteLine("Суббота");
}
if (DayNumber == 7) 
{
    Console.WriteLine("Воскресенье");
}
if (DayNumber > 7) 
{
    Console.WriteLine("Дня недели с таким номером не существует");
}
if (DayNumber <= 0)
{
    Console.WriteLine("Неверно введено число");
}