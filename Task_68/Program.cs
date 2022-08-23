// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
int InNum(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int Akkerman (int m, int n)
{
    if (m==0) return n+1;
    else if (n==0) return Akkerman(m-1,1);
    else return Akkerman(m-1,Akkerman(m,n-1));
}
int m = InNum("Введите первое число M: ");
int n = InNum("Введите второе число N: ");
int funcAkkerman = Akkerman(m, n);
Console.WriteLine($"Функция чисел Аккермана {m}, {n} составляет -> {funcAkkerman}");