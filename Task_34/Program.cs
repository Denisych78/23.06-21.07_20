﻿// Задача 34: Задайте массив заполненный случайными положительными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 243] -> 2

Console.Clear();
Console.WriteLine("Введите длину массива с целью опеределения количества чётных чисел в нём");

int sizeArr = int.Parse(Console.ReadLine());

int[] CreateArrayRndInt(int sizeArray)
{
    int[] array = new int[sizeArray];
    Random rnd = new Random();
    for (int i = 0; i < sizeArray; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

int EvenArrayNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
        else
        {
            count = count;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("Массив [");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.WriteLine(array[i] + "]");
    }
}

int[] array = CreateArrayRndInt(sizeArr);
PrintArray(array);
int resultCount = EvenArrayNumbers(array);
Console.WriteLine($"Количество чётных чисел в массиве: {resultCount}");
