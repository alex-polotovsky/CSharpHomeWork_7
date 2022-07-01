/* Задача 50: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет. */

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

Console.Write("Введите через запятую индекс искомого элемента: ");
string s = Console.ReadLine();
string [] subs = s.Split(",");

int i = int.Parse(subs[0]);
int j = int.Parse(subs[1]);

if (i < m && j < n)
{    
    Console.WriteLine("Значение элемента: " + mass [i, j]);
}
else
{
    Console.WriteLine("Такого элемента нет.");
}