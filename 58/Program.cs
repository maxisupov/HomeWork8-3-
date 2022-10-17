// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Количество строк первого массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество столбцов первого массива: ");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine();

Console.WriteLine("Количество строк второго массива: ");
int rows2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество столбцов второго массива: ");
int columns2 = int.Parse(Console.ReadLine()!);

Console.WriteLine();

Console.WriteLine("Первый массив: ");
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();

Console.WriteLine("Второй массив: ");
int[,] array2 = GetArray(rows, columns, 0, 10);
PrintArray(array2);
Console.WriteLine();

int[,] multiArray = new int[rows, columns];

MultiplyArray(array, array2, multiArray);
PrintArray(multiArray);


void MultiplyArray(int[,] array, int[,] array2, int[,] multiArray)
{
  for (int i = 0; i < multiArray.GetLength(0); i++)
  {
    for (int j = 0; j < multiArray.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < array.GetLength(1); k++)
      {
        sum = sum + array[i,k] * array2[k,j];
      }
      multiArray[i,j] = sum;
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