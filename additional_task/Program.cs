// Доп. задание
// Написать метод для разворота массива,
// не используя память под дополнительный массив

void ArrayRev(int[] array) // метод разворота массива
{
    for (int i = 0; i < array.Length / 2; i++)
    {
         int temp = array[i];
         array[i] = array[array.Length - 1 - i];
         array[array.Length - 1 - i] = temp;
    }
}

void PrintArray(int[] array) // метод вывода массива в терминал в строку
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
Console.WriteLine();
PrintArray(arr); // метод выводит исходный массив
Console.WriteLine();
ArrayRev(arr);
PrintArray(arr); // метод выводит перевернутый массив




