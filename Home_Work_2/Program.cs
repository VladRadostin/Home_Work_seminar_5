// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Clear();

double[] arr = new double[10];

void FillArrayRandom(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        double double_1 = new Random().NextDouble();
        int int_1 = new Random().Next(1, 100);
        array[i] = Math.Round(double_1, 2) + int_1;
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double ArrayMaxMin(double[] array)
{
    int minim = 0;
    int maxim = 0;
    double amount = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (array[maxim] <= array[i])
        {
            maxim = i;
        }

        if (array[minim] >= array[i])
        {
            minim = i;
        }
    }
    amount = array[maxim] - array[minim];

    Console.WriteLine($"---------------------------");
    Console.WriteLine($" max = {array[maxim]} : min = {array[minim]}");
    Console.WriteLine($"---------------------------");

    return Math.Round(amount, 2);
}

FillArrayRandom(arr);
PrintArray(arr);
Console.WriteLine(ArrayMaxMin(arr));