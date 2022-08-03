// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] arr = GetRandomArray(8); //создаем массив  из 8 элементов
WriteArrayToConsole(arr);

int[] GetRandomArray(int arrayLength)
{
    Random rnd = new Random(); //используем метод рандом и перебираем его
    int[] arr = new int[arrayLength];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next();
    }
    return arr;
}

void WriteArrayToConsole(int[] array) // используем метод который ничего не возвращает
{
    for (int i = 0; i < array.Length; i++) //
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
            Console.Write(",");
    }

    Console.Write(" -> ["); //отображаем открытую скобку
    for (int i = 0; i < array.Length; i++) 
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
            Console.Write(",");
    }
    Console.WriteLine("]"); // отображаем закрытую скобку
}