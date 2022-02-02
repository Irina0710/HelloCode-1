﻿// // // 54. В матрице чисел найти сумму элементов главной диагонали (индекс i и j должен совпадать)
int[,]matrix = new int[6,6];

void PrintFillArray(int[,] mat)
{
    for  (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            mat[i,j] = new Random().Next(1,10);
            System.Console.Write($"{mat[i,j]} ");
        }
        System.Console.WriteLine();
    }
}
PrintFillArray(matrix);
System.Console.WriteLine();

int SumOfDiagonal = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i==j)
        {
            SumOfDiagonal = SumOfDiagonal + matrix[i,j];
        }
    
    }
}
System.Console.Write($"Сумма элементов главной диагонали = {SumOfDiagonal}");


