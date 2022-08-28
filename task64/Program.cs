//Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1

Console.WriteLine("Введите число N ");
int number = Convert.ToInt32(Console.ReadLine());

PrintNumbersToN(number);


 void PrintNumbersToN(int N)
 {
    if ( N < 1) return;
    PrintNumbersToN (N - 1);
    Console.Write(N + " ");
 }
