// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

Console.WriteLine("Введите значение b1:");
double B1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1:");
double K1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2:");
double B2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2:");
double K2 = Convert.ToInt32(Console.ReadLine());

void CrossingYX(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    Console.WriteLine($"Точкой пересечения двух прямых является точка ({x};{y})");
}

CrossingYX(B1, K1, B2, K2);
