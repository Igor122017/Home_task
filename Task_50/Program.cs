// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

Console.WriteLine("Программа для вывода элемента массива по его координатам.");
double[,] array = CreateArray(5, 10, 10);
WriteArrayToConsole(array);
Console.Write("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());

double? resNum = FindItemByIndex(array, row, column);

Console.WriteLine(resNum == null ? $"{row},{column} -> такого элемента нет" : $"{row},{column}-> {resNum:F2}");


double? FindItemByIndex(double[,] arr, int row, int column)
{
    if (row > arr.GetLength(0) || column > arr.GetLength(1))
        return null;
    return arr[row-1, column-1];
    
}

double[,] CreateArray(int rows, int columns, int mnozhitel = 1)
{
    var rnd = new Random();
    var array = new double[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int znak = rnd.Next(0, 2) == 1 ? -1 : 1;
            array[i, j] = rnd.NextDouble() * mnozhitel * znak;
        }
    }

    return array;
}

void WriteArrayToConsole(double[,] array, int round = 2)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i, j], 2) + " ");
        }

        Console.WriteLine();
    }
}