//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
int[] a = new int[8];
for(int i = 0;i<8;i++)
{
Console.WriteLine("Введите {0}-й элемент", i + 1);
a[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine('[' + string.Join(",", a) + ']');
Console.WriteLine("Введите число");
int find = Convert.ToInt32(Console.ReadLine());
int n = a.Length;;
int index = 0;
int f = 0;
while (index < n)
{
    if (a[index] == find)
    {
        f = 1;
    }
    index++;
}
if (f == 1)
{
    Console.WriteLine("Введённое число присутствует в массиве");
}
if (f == 0)
{
Console.WriteLine("Введённое число отсутсвует в массиве");
}

