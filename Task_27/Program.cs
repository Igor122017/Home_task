// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число для подсчета суммы цифр: "); //просим ввести число
int num = Convert.ToInt32(Console.ReadLine()); //считываем эти числа

int sum = GetDigitSum(num); //присваеваем 

Console.WriteLine($"{num} -> {sum}"); //выводим на экран


int GetDigitSum(int number)
{
    int result = 0; 

    while (number >= 1) //используем цикл
    {
        result += number % 10;
        number /= 10;
    }

    return result; //возвращаем результат
}