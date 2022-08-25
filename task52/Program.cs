//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] FillRandomDoubleMatrix(int lines = 4, int colums = 4, int leftRange =1, int rightRange = 10)
{
    Random rand = new Random();
    int[,] matr = new int[lines, colums];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
       for (int j =0; j < matr.GetLength(1); j++);
        {
            matr[i,j] = rand.Next(leftRange, rightRange + 1);
            Console.Write(matr[i, j] + " ");
        } 
    
    }
    return matr;
}


int[] matrix = FillRandomDoubleMatrix();