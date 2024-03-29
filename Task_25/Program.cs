﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int NatDegree(int number, int degree)
{
    int result = 1;
    for (int i = 1; i <= degree; i++)
    {
        result = result * number;
    }
    return result;
}

void PrintDegree(int Exp)
{
    Console.Write($"Результат возведения числа {A} в степень {B} равен {Exp}");
}

int res = NatDegree(A, B);
PrintDegree(res);