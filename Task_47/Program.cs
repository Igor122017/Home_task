// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine();
double[,] array = CreateArray(3,4,10);
WriteArrayToConsole(array);


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