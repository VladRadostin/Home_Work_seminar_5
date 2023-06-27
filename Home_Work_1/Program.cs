// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int[] arr = new int[10];

void FillArrayRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void oddnumber(int[] array)
{
    Console.Write($"Число на нечётной позиции: ");
    int amount = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        Console.Write($"{array[i]} ");
        amount = amount + array[i];
    }
    Console.WriteLine(" ");
    Console.WriteLine($"Сумма чисел: {amount}");
}


FillArrayRandom(arr);
PrintArray(arr);
oddnumber(arr);