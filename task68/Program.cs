// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9

Console.WriteLine("Введите положительное число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительное число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

 int result = FunctionAkker(numM,numN);
 Console.WriteLine(result);

int FunctionAkker(int M, int N)
{
    if (M == 0) 
    return N + 1;
    else 
    if (N == 0) 
    return FunctionAkker(M - 1, 1);

    return FunctionAkker(M - 1, FunctionAkker(M, N - 1));
}