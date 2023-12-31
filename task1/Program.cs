﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string GetNumbers(int n)
{
    if (n == 1) return n.ToString();
    return n + ", " + GetNumbers(n-1);
}

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Натуральный числа в промежутке от N до {n}: -->  ");
Console.Write(GetNumbers(n));