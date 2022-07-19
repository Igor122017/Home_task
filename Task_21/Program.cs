// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
// в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите координаты  первой точки: ");

Console.Write("x: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("f: ");
int f1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
Console.Write("x: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("f: ");
int f2 = Convert.ToInt32(Console.ReadLine());

double Dist(int ax, int ay, int af, int bx, int by, int bf)
{
    return Math.Round(Math.Sqrt(((bx - ax) * (bx - ax) + (by - ay) * (by - ay) + (bf - af) * (bf - af))), 2, MidpointRounding.ToZero);
}
double result = Dist(x1, y1, f1, x2, y2, f2);
Console.WriteLine($"-> {result}");