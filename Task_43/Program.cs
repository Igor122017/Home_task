// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Поиск точки пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");

double b1 = GetUserInDouble("Введите b1: ");
double k1 = GetUserInDouble("Введите k1: ");
double b2 = GetUserInDouble("Введите b2: ");
double k2 = GetUserInDouble("Введите k2: ");


double[] point = FindCross(k1, b1, k2, b2);

Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({point[0]}, {point[1]}) ");

double[] FindCross(double k1, double b1, double k2, double b2)
{
    double x = (-b1 + b2) / (k1 - k2);
    double y = k1 * x + b1;
    return new double[]{x, y};
}

double GetUserInDouble(string msg)
{
    Console.Write($"{msg}: ");
    if (!double.TryParse(Console.ReadLine(), out double result))
    {
        Console.WriteLine("Неверный ввод! повторите.");
        GetUserInDouble(msg);
    }
    return result;
}
