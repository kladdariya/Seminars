// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру, обозначающую день недели: ");

int namberDay = Convert.ToInt32(Console.ReadLine());

if (namberDay == 6 || namberDay == 7)
{
    Console.WriteLine("Да");
}
else 

if (namberDay >= 1 && namberDay <= 5)
    {
        Console.WriteLine("Нет");
    }
 else 
 {
    Console.WriteLine("Это не день недели");
 }
