//Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

int []FillArrayWithRandomNumber(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int [size];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int[] array = FillArrayWithRandomNumber(123,8,340);
int count = 0;

for (int i = 0; i < array.Length; i++)
{
if (array[i] >= 10 && array[i] <= 99)
{
    count ++;
}
}

Console.WriteLine('[' + string.Join(",", array) + ']');
Console.WriteLine($"Количество чисел = {count}");
