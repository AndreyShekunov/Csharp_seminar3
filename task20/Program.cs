// Задача 20: Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 2D пространстве.
// Например:
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координату Х точки A");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату У точки A");
int ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Х точки B");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату У точки B");
int yb = Convert.ToInt32(Console.ReadLine());

double res = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2));
Console.WriteLine($"{res:f3}");
