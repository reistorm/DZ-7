// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int cols = int.Parse(Console.ReadLine());

int[,] GetArray(int row, int col)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(10);

        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();

    }
}
int[,] array = GetArray(rows, cols);
double[] sum = new double[cols];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 1; j < array.GetLength(1); j++)
    
    {
        sum[i] = sum[i] + array[j-1, i];
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    double result = sum[i] / cols;
    Console.Write($"Среднее арифметическое каждого столбца: {result}");
    Console.WriteLine();

}







int[,] arrayResult = GetArray(rows, cols);
Console.WriteLine("Массив: ");
PrintArray(arrayResult);

