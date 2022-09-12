// Разворот числа

int number = 12345; // Исходное число
int tempNumber = number; // Число, которое будем разворачивать
int reversedNumber =0; // развернутое число
while(tempNumber > 0)
{
    int digital = tempNumber % 10;
    reversedNumber = reversedNumber * 10 + digital;
    tempNumber = tempNumber / 10;
}
Console.WriteLine($"Развёрнутое число = {reversedNumber}");