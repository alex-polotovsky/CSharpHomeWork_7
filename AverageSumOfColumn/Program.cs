/* Задача 52: Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце. */

void PrintArrTwo(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
       for (int j = 0; j < matr.GetLength(1); j++)
       {
        Console.Write(matr[i, j] + " ");
       } 
       Console.WriteLine(); 
    }   
}


void FillArrTwo(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }    
    }
}


Console.Write("количество строк m: ");
int m = int.Parse(Console.ReadLine());

Console.Write("количество столбцов n: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine();

int[,] mass = new int[m, n];

PrintArrTwo(mass);
Console.WriteLine();
FillArrTwo(mass, 1, 9);
PrintArrTwo(mass);
Console.WriteLine();

double [] average = new double [n];

for (int i = 0; i < mass.GetLength(1); i++)
{
    for (int j = 0; j < mass.GetLength(0); j++)
    {
        average[i] += mass[j, i];
        if (j == mass.GetLength(0) - 1)
        {
            average[i] = Math.Round(average[i] / m, 2);
        }
    }
}

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"average col {i + 1} = {average[i]}");
}


