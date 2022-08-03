// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
 
Console.Write("Введите число для возведения в степень: "); //просим ввести число
int num = Convert.ToInt32(Console.ReadLine()); //считываем числа
Console.Write("Введите степень: "); //просим ввести степень
int pow = Convert.ToInt32(Console.ReadLine()); //считываем эту степень

int numPower = GetPower(num, pow);

Console.WriteLine($"{num},{pow} -> {numPower}"); //выводим значение 


int GetPower(int number, int power)
{
    int i = 2;
    int poweredNumber = number;
    while (i <= power)
    {
        poweredNumber *= number;
        i++;
    }

    return poweredNumber;
}