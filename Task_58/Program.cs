//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, заданы 2 массива:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//1 5 8 5
//4 9 4 2
//7 2 2 6
// 3 4 7
//Их произведение будет равно следующему массиву:
//1 20 56 10
//20 81 8 6
//56 8 4 24
//10 6 24 49

Console.Clear();
int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3},");
            else Console.Write($"{array[i, j],3}]");
        }
        Console.WriteLine();
    }
}

int UserInputInt(string userInputStr)
{
    Console.WriteLine(userInputStr);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,] Multiply(int[,] first, int[,] second)
{
    if (!IsLengthEqual(first, second))
        return null;

    int firstRows = first.GetLength(0);
    int firstCols = first.GetLength(1);
    int secondCols = second.GetLength(1);
    int secondRows = second.GetLength(0);
    var newArray = new int[firstRows, secondCols];
    
    for (int i = 0; i < firstRows; i++)
    {
        for (int j = 0; j < secondCols; j++)
        {
            for (int k = 0; k < secondRows; k++)
            {
                newArray[i, j] += first[i, k] * second[k, j];
            }
        }
    }

    return newArray;
}
bool IsLengthEqual(int[,] first, int[,] second) =>
    (first.GetLength(0) == second.GetLength(1));

int m = UserInputInt("Введите длину строки массива: ");
int n = UserInputInt("Введите длину  столбцов массива: ");

//int[,] firstmatrix = GetMatrix(m, n);
//int[,] secondmatrix = GetMatrix(m, n);
PrintMatrix(firstmatrix);
Console.WriteLine();
PrintMatrix(secondmatrix);

Console.WriteLine();
int[,] resultMatrix = Multiply(firstmatrix, secondmatrix);
PrintMatrix(resultMatrix);