// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using System.Text;
int[] intArray = CreateArrayRandomInt(10, 100, 999);
int positiveCount = CountPositiveNums(intArray);

Console.WriteLine($"{WriteArrayAsString(intArray)} -> {positiveCount}");


int CountPositiveNums(int[] array)
{
    int counter = 0;
    foreach (var a in array)
    {
        if (a % 2 == 0)
            counter++;
    }
    return counter;
}

int[] CreateArrayRandomInt(int arrayLength, int minValue, int maxValue)
{
    int[] array = new int[arrayLength];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue);
    }
    return array;
}

string WriteArrayAsString(int[] array)
{
    StringBuilder sb = new StringBuilder();
    sb.Append("[");
    for (int i = 0; i < array.Length; i++)
    {
        sb.Append(array[i]);
        if (i < array.Length - 1)
            sb.Append(", ");
    }
    sb.Append("]");

    return sb.ToString();
}