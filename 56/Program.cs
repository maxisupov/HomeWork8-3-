// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

Console.WriteLine();

Console.WriteLine("Полученный массив: ");
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();


    int minSum = 0;
    int sumRow0 = GetSumRows(array, 0);   
    for(int i = 1; i < array.GetLength(0); i++)
    {
        int sumRow1 = GetSumRows(array, i);
        if(sumRow0 > sumRow1)
        {
            
            sumRow0 = sumRow1;
            minSum = i;
        }
    }

Console.WriteLine($"Строка с наименьшей суммой элементов - {minSum + 1} ");


   

int GetSumRows(int[,] array, int i)
{   
    int SumRow = array[i,0];    
    for(int j = 0; j < array.GetLength(1); j++)
    {
        {
            SumRow = SumRow + array[i,j];
        }            
    }    
    return SumRow;
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