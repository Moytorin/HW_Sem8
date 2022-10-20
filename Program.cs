// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();

ChangeRows(array);
PrintArray(array);
Console.WriteLine();

void ChangeRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int w = 0; w < array.GetLength(1) - 1; w++)
            {
                if (array[i, w] < array[i, w + 1])
                {
                    int temp = array[i, w + 1];
                    array[i, w + 1] = array[i, w];
                    array[i, w] = temp;
                }
            }
            Console.WriteLine();
        }
    }
}
    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("[");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine("]");
        }
    }

    int[,] GetArray(int m, int n, int minValue, int maxValue)
    {
        int[,] result = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i, j] = new Random().Next(minValue, maxValue + 1);
            }
        }
        return result;
    }
 
