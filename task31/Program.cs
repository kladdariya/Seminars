//31.Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива
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

void sumPositiveAndNegativeElements(int[] arr, out int sumPositive, out int sumNegative)
{
sumPositive = 0;
sumNegative = 0;

for (int i = 0; i < arr.Length; i++)
{
if (arr[i] > 0)
{
    sumPositive += arr[i];
}
if (arr[i] < 0)
{
    sumNegative +=arr[i];
}
}
}
int[] array = FillArrayWithRandomNumber(12, -9, 9);
sumPositiveAndNegativeElements(array, out int sumP, out int sumN);

Console.WriteLine('[' + string.Join(",", array) + ']');
Console.WriteLine($"Сумма положительных чисел = {sumP}, отрицательных = {sumN}");