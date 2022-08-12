//Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] FillArrayWithRandomNumber(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int [size];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int[] array = FillArrayWithRandomNumber(12, -9, 9);
Console.WriteLine('[' + string.Join(",", array) + ']');
int[] arr = array.Select(r=> r * (-1)).ToArray();
Console.WriteLine('[' + string.Join(",", arr) + ']');