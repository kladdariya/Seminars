//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите х1: ");
double x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите х2: ");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите z1: ");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите z2: ");
double z2 = Convert.ToInt32(Console.ReadLine());

double rezult = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) +  Math.Pow((z2 - z1),2));

Console.WriteLine (rezult);

//AB = √(xb - xa)2 + (yb - ya)2
//Формула вычисления расстояния между двумя точками A(xa, ya, za) и B(xb, yb, zb) в пространстве:
//AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

