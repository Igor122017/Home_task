// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = CreateArray(5, 6, 0, 9);
WriteIntArrayToConsole(array);

double[] avgArr = GetAvgInColumns(array);
Console.Write("Среднее арифметическое каждого столбца: ");
WriteDoubleArrayToConsole(avgArr);

double[] GetAvgInColumns(int[,] arr)
{
    int rowLength = arr.GetLength(0);
    int columnLength = arr.GetLength(1);
    var avg = new double[columnLength];

    for (int i = 0; i < columnLength; i++)
    {
        double sum = 0;
        for (int j = 0; j < rowLength; j++)
        {
            sum += arr[j,i];
        }

        avg[i] = sum / (double)rowLength;
    }

    return avg;
}

int[,] CreateArray(int rows, int columns, int min, int max)
{
    var rnd = new Random();
    var array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }

    return array;
}

void WriteDoubleArrayToConsole(double[] array, int round = 2)
{
    Console.Write($"[{array[0]}");

    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", {Math.Round(array[i], round)}");
    }
    Console.WriteLine("]");
}

void WriteIntArrayToConsole(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }

        Console.WriteLine();
    }
}