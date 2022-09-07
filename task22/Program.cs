// Задача 22: Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.
// Например:
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите положительное число:");
int N = Convert.ToInt32(Console.ReadLine());

if(N > 0)
{
    int count = 1;
    while(count <= N)
    {
        Console.Write(count * count + " ");
        count++;
    }
}
else
{
    Console.WriteLine("Введено отрицательное число или ноль.");
}
