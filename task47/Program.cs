﻿//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write("Введите m = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n = ");
int m = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(10);
        Console.Write(matrix[i, j] + " ");

    }

    Console.WriteLine();
}