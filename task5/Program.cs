//Задача 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = -N;
while(count<=N)
{
    Console.WriteLine(count);
    count++; 

}
