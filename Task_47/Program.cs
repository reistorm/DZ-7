﻿// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int cols = int.Parse(Console.ReadLine());

double[,] GetArray(int row, int col)
{
    double[,] array = new double[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.NextDouble() * 100;
            
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          
          Console.Write(Math.Round(array[i,j], 3, MidpointRounding.AwayFromZero ));
          Console.Write(" ");
        }
        Console.WriteLine();
    }
}
double[,] arrayResult = GetArray(rows, cols);
Console.WriteLine("Массив: ");
PrintArray(arrayResult);
