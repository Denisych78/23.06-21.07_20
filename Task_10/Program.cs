﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int Num = a / 10 - a / 100 * 10;
Console.WriteLine($"Второй цифрой введенного Вами числа является: {Num}");