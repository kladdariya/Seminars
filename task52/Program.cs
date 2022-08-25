//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] FillRandomDoubleArray(int lines = 4, int colums = 4, int leftRange = 1, int rightRange = 10)
{
    int[,] randomArray = new int[lines, colums];
    Random rand = new Random();
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            randomArray[i, j] = rand.Next(leftRange, rightRange + 1);
        }

    }
    return randomArray;

}

int[,] array = FillRandomDoubleArray();
PrintMatrix(array);

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    double result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = sum + array[i, j];


    }
    
    result = sum / array.GetLength(1);
    Console.Write($"{result}; ");
}
