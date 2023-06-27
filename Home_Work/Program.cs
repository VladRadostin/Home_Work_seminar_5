// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int[] arr = new int[10];

void FillArrayRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] =  new Random().Next(100, 1000);
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

void even_numbered(int[] array)
{
    Console.Write($"Чётное число: ");
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] % 2) == 0)
        {
            Console.Write($"{array[i]} ");
            count++;
        } 
    }

    Console.WriteLine("");
    Console.WriteLine($"Всего чётных чисел: {count}");
}

FillArrayRandom(arr);
PrintArray(arr);
even_numbered(arr);