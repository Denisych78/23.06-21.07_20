// Напишите программу, которая принимает
// на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// Console.WriteLine("Введите число:");
// int num = int.Parse(Console.ReadLine());

// void Fact(int number)
// {
//     int temp = 1;
//     for (int i = 1; i <= number; i++)
//     {
//         temp *= i;
//     }
//     Console.WriteLine(temp);
// }

// Fact(num);



Console.WriteLine("Введите число:");

int n = int.Parse(Console.ReadLine());

decimal res = 1;
int start = 1;

while (start <= n)
{
    try
    {
        checked
        {
            res *= start;
            start++;
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Переполнение типа!");
        break;
    }
}

Console.WriteLine($"Произведение чисел от 1 до {start - 1} равно {res}");
