// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5      7       -2      -0,2
// 1        -3,3    8       -9,9
// 8        7,8     -7,1    9

// Я РЕШИЛ, ЧТО С ОГРАНИЧЕНИЕМ РАНДОМА ДО 10 и ОКРУГЕНИЕМ БУДЕТ ПОСИМПОТИЧНЕЕ

Console.Write("Ведите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];
var element = new Random();


for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = element.NextDouble() * 10;
        array[i, j] = Math.Round(array[i, j], 2);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}