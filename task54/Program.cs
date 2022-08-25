//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

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

int[,] array = FillRandomDoubleArray();
PrintMatrix(array);

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(1) - 1; k++)
        {
            if (array[i, k] > array[i, k + 1])
            {
                int temp = array[i, k + 1];
                array[i, k + 1] = array[i, k];
                array[i, k] = temp;
            }
        }
    } 
}
 Console.WriteLine();
PrintMatrix(array);





