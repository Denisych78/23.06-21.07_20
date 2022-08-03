// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// А (3,6); В (2,1) -> 5,09
// А (7,-5); В (1, -1) -> 7,21

Console.Clear();

Console.WriteLine("Введите координаты точки А: ");
Console.Write("xA: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("yA: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
Console.Write("xB: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("yB: ");
int yB = Convert.ToInt32(Console.ReadLine());

double AB = Math.Sqrt(Math.Pow((xA-xB), 2) + Math.Pow((yA-yB), 2));
Console.WriteLine(Math.Round(AB, 2));
