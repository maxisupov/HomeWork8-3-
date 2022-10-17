// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.WriteLine("Количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество глубину массива: ");
int depth = int.Parse(Console.ReadLine()!);

Console.WriteLine();

Console.WriteLine("Полученный трехмерный массив: ");
int[,,] array = GetArray(rows, columns, depth);
PrintArray(array);
Console.WriteLine();

Console.WriteLine("Массив, после добавления индексов: ");
GetNewArray(array);


void GetNewArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            {                
                for( int k = 0; k < array.GetLength(0); k++)
                    {
                        Console.Write( $"{array[i,j,k]}({i},{j},{k}) ");
                    }
                Console.WriteLine();
            }
            Console.WriteLine();
    }
   
}


int[,,] GetArray(int m, int n, int x)
{
    int[,,] result = new int[m, n, x];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
            {
                for( int k = 0; k < x; k++)
                    {
                        result[i,j,k] = new Random().Next(10, 99);
                    }
            }
    }
    return result;
}

void PrintArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            {
                for( int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write($"{array[i,j,k]} ");
                    }
                    Console.WriteLine();
            }
    }
    
}

