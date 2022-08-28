//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите N: ");

double N = Convert.ToInt32(Console.ReadLine());
int count = 1;

while(count <= N)
{
    Console.WriteLine(Math.Pow(count,3));
    count++;
}

//Math.Pow(count,3) вщзведение count в куб (третья степень)
