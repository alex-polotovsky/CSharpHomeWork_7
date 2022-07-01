/* Задача 47: Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
 */

 void FillArrTwoDouble(double [,] mat, int min, int max)
 {
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            mat [i, j] = Math.Round (new Random().Next(min, max + 1) + new Random().NextDouble(), 3);
        }
    }
 }


void PrintArrTwoDouble(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
       for (int j = 0; j < matr.GetLength(1); j++)
       {
        Console.Write(matr[i, j] + "\t");
       } 
       Console.WriteLine(); 
    }
    
}
 double [,] matrx = new double [3, 4];

PrintArrTwoDouble(matrx);
Console.WriteLine();
FillArrTwoDouble(matrx, 0, 9);
PrintArrTwoDouble(matrx);
