// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
int n = InNum("Введите первое число: ");
int m = InNum("Введите второе число: ");
int result = SumNum(n, m);
Console.WriteLine($"Сумма в промежутке от {n} до {m} составляет -> {result}");

int SumNum(int n, int m)
{
    if (n == m) return n;
    if (n < m) return n + SumNum(n + 1, m);
    else return m + SumNum(n, m + 1);
}

int InNum(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}