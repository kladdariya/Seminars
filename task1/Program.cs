//Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратoм второго.
Console.WriteLine("Введите число: ");

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2)

{
    Console.WriteLine("yes");

}

else

{
    Console.WriteLine("no"); 
}
