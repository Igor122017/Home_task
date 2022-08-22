//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.
//массив размером 2 x 2 x 2
//12(0,0,0) 22(0,0,1)
//45(1,0,0) 53(1,0,1)

Console.Clear();
int[,,] matrix = GetMatrix(2, 2, 2);

int[,,] GetMatrix(int a, int b, int c)
{
    int[,,] matrix = new int[a, b, c];
    int len = matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2);
    int[] matTemp = new int[len];
    for (int i = 0; i < len; i++)
    {
        matTemp[i] = 10 + i;
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = matTemp[len - 1];
                len--;
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($" значение {array[i, j, k]} индекс массива ({i},{j},{k})", 3);
            }
        }
    }
}

PrintMatrix(matrix);
Console.WriteLine();
