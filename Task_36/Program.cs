// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using System.Text;
int[] intArray = CreateArrayRandomInt(10,-100, 100);
int oddSum = GetOddSum(intArray);

Console.WriteLine($"{WriteArrayAsString(intArray)} -> {oddSum}");


int GetOddSum(int[] array)
{
    int sum = array[1];
    for (int i = 3; i < array.Length; i+=2)
    {
        sum+=array[i];
    }
    return sum;
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