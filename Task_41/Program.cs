//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

Console.Clear();
Console.WriteLine("Подсчет количества > 0.");

int[] array = GetArrayInUser();

int NumCount = CountNum(array);

Console.WriteLine($"{WriteArrayStr(array)} -> {NumCount}");

int CountNum(int[] arr) => arr.Count(i => i > 0);

string WriteArrayStr(int[] arr) => $"[{string.Join(", ", arr)}]";

int[] GetArrayInUser()
{
    while (true)
    {
        Console.Write("Введите чисела через запятую: ");
        var userInStr = Console.ReadLine();

        int[] arr = GetArray(userInStr);
        if (arr != null) return arr;

        Console.WriteLine("Ошибка! Попробуйте снова.");
    }

}

int[] GetArray(string? str)
{
    if (string.IsNullOrEmpty(str) || !str.Contains(','))
    {
        return null;
    }

    var arr = str.Split(",");

    var intArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (!int.TryParse(arr[i], out int j))
        {
            return null;
        }

        intArr[i] = j;
    }

    return intArr;
}

