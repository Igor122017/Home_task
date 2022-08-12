// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
// элементов массива.
// [3 7 22 2 78] -> 76

using System.Text;
double[] doubleArray = FillArrayRandomDouble(10, 10,2);

double diffMinMax = GetDiffMinMax(doubleArray);

Console.WriteLine($"{WriteArrayAsString(doubleArray)} -> {diffMinMax:F2}");

double GetDiffMinMax(double[] array)
{
    double min = array[0];
    double max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            continue;
        }
        if(array[i] > max)
            max = array[i];
    }

    return max - min;
}

double[] FillArrayRandomDouble(int arrayLength, int factor = 1, int? round = null)
{
    double[] array = new double[arrayLength];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        var val = rnd.NextDouble() * factor;
        array[i] = round == null ? val : Math.Round(val, (int)round);
    }
    return array;
}

string WriteArrayAsString(double[] array)
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