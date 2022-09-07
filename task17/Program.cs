// 17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координату точки по Х");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки по У");
int y = Convert.ToInt32(Console.ReadLine());

if(x > 0 && y > 0)
{
    Console.WriteLine("Находится в первой координатной чертверти");
}
else if(x < 0 && y > 0)
{
    Console.WriteLine("Находится во второй координатной чертверти");
}
else if(x < 0 && y < 0)
{
    Console.WriteLine("Находится в третьей координатной чертверти");
}
else if(x > 0 && y < 0)
{
    Console.WriteLine("Находится в четвертой координатной чертверти");
}
else
{
    Console.WriteLine("Введена нулевая координата Х и/или У");
}