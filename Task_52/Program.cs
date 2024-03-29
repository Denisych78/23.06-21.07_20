﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
int[,] CreateMatrixRndInt(int m, int n)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(0, 10);
        }
    }
    return arr;
}

double[] Average(int[,] arr)
{
    double[] avg = new double[arr.GetLength(0)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int count = 0;
        double sum = 0;
        for (int i = 0; i < arr.GetLength(1); i++)
            {
                sum += arr[i,j];
                count++;
            }
            
            avg[j] = Math.Round(sum/count,2);

        }
     return avg;
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

void PrintAvg(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0)
            Console.Write("[");
        if (i < arr.Length - 1)
            Console.Write(arr[i] + ";");
        else
            Console.Write(arr[i] + "]");
    }
    Console.WriteLine();
}

int[,] array = CreateMatrixRndInt(3, 3);
PrintMatrix(array);
double[] average = Average(array);
Console.WriteLine("Среднее арифметическое элементов в столбцах:");
PrintAvg(average);