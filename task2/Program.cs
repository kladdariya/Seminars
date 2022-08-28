//Задача 2: Напишите программу, которая на вход принимает два 
//числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите число: ");

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;
int min = number1;

if ( number1 > max ) max = number1;
if ( number2 > max ) max = number2;
if ( number1 < min ) min = number1;
if ( number2 < min ) min = number2;

{
    
    Console.Write ("max = ");
    Console.WriteLine (max);

    Console.Write ("min = ");
    Console.WriteLine (min);

}
