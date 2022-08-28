//Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число М ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());

int res = SetSumDigits(N,M);
Console.WriteLine(res);

int SetSumDigits(int N, int M)
{

    if (M>=N) return N;
    
    return N + SetSumDigits(N-1,M);
}
