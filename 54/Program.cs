// // Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

Console.WriteLine();

Console.WriteLine("Полученный массив: ");
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();

Console.WriteLine("Массив, после упорядочивания элементов по убыванию: ");
ArrangeArray(array);
PrintArray(array);


void ArrangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for(int newJ = 0; newJ < array.GetLength(1)-1; newJ++)
            {
                if (array[i, newJ] < array[i, newJ + 1])
                {
                    int temp = array[i, newJ + 1];
                    array[i, newJ + 1] = array[i, newJ];
                    array[i, newJ] = temp;
                }
            }
        }

    }
}



int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}