// Задача 18: Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер координатной четверти от 1 до 4:");
int quarter = Convert.ToInt32(Console.ReadLine());

if(quarter > 0 && quarter < 5)
{
    if(quarter == 1)
    {
        Console.WriteLine("Диапазон: х > 0 и y > 0");
    }
    if(quarter == 2)
    {
        Console.WriteLine("Диапазон: х < 0 и y > 0");
    }
    if(quarter == 3)
    {
        Console.WriteLine("Диапазон: х < 0 и y < 0");
    }
    if(quarter == 4)
    {
        Console.WriteLine("Диапазон: х > 0 и y < 0");
    }
}
else
{
    Console.WriteLine("Существует только 4 координатные четверти");
}