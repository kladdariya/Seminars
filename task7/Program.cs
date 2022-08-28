
//Задача 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(N % 10);