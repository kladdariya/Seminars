// Задача 38: Задайте с клавиатуры массив вещественных (double) чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Задать размер (int) массива с клавиатуры
// [3 7 22 2 78] -> 76
// ввод массива с клавиатуры

Console.WriteLine("Введите размер массива: ");
double size = Convert.ToInt32(Console.ReadLine());
double[] a = new double[size];
for(int i = 0; i<size ;i++)
{
Console.WriteLine("Введите {0}-й элемент", i + 1);
a[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine('[' + string.Join(",", a) + ']');
double max = a[0];
double min = a[0];
for ( int i = 0; i < size; i++)
{
    if (a[i] > max)
    {
        max = a[i];
    }
    if (a[i]<min)
    {
        min = a[i];
    } 
}
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

//  надо исправить на double