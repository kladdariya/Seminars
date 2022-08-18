//Задача 41: Пользователь вводит с клавиатуры M чисел в одну линию (не используем Enter). Числа разделены пробелами. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите число М: ");
int[] numbers = Console.ReadLine().Split().Select(x => Convert.ToInt32(x)).ToArray();

Console.WriteLine('[' + string.Join(",", numbers) + ']');
 int count = 0;
 for (int i = 0; i<numbers.Length; i++)
{
     if (numbers[i] > 0)
     {
        count= count+1;
     }
}

Console.WriteLine($"Количество чисел больше 0 = {count}");
