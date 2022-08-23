//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите m = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n = ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j] + " ");

    }

    Console.WriteLine();
}

Console.WriteLine("Введите первую координату позиции элемента  ");
int cos = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первую координату позиции элемента  ");
int pos = Convert.ToInt32(Console.ReadLine());
if (cos<m-1 && pos<n-1)
{
    Console.WriteLine($"Значение элемента {matrix[cos,pos]}");
}
else
{
    Console.WriteLine($"Числа с координатами [{cos},{pos}] нет в массиве");
}





