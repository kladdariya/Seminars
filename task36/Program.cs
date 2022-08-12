//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

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


void sumOddElements(int[] arr, out int sumOdd)
{sumOdd = 0;
for (int i = 1; i < arr.Length; i+=2)
{
sumOdd += arr[i]; 
}
}

int[] array = FillArrayWithRandomNumber(5,1,10);
sumOddElements(array, out int sumOdd);

Console.WriteLine('[' + string.Join(",", array) + ']');
Console.WriteLine($"Сумма элементов на нечетных позициях = {sumOdd}");

