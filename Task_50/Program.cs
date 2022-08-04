// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

Console.Clear();

int[,] CreateMatrixRndInt(int m, int n)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(10, 99);
        }
    }
    return arr;
}

void FindElement(int[,] arr, int line, int column)
{
    if (line< arr.GetLength(0)+1 && column <arr.GetLength(1)+1)
    {
        Console.WriteLine($"Значением элемента в строке {line} и столбце {column} является {arr[line-1, column-1]}");
    }
    else Console.WriteLine("Нет нужного элемента");
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0)
                Console.Write("|");
            if (j < arr.GetLength(1) - 1)
                Console.Write($"{arr[i, j], 3} | ");
            else
                Console.Write($"{arr[i, j], 3} | ");
        }
        Console.WriteLine();
    }
}

int[,] array = CreateMatrixRndInt(7, 7);
PrintMatrix(array);
Console.WriteLine("Введите строку элемента");
int stroka = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец элемента");
int stolbets = Convert.ToInt32(Console.ReadLine());
FindElement(array, stroka, stolbets);