// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.



int InputRowCol(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] CreateMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}


int[,] ArrangeRow(int[,] array)
{
    for(int row = 0; row < array.GetLength(0); row++)
        for(int i = 0; i < array.GetLength(1); i++)
            for(int j = array.GetLength(1)-1; j>i; j--)
                if(array[row, j] > array[row, j-1])
                {
                    int temporary = array[row, j];
                    array[row, j] = array[row, j-1];
                    array[row, j-1] = temporary;
                }
    return array;
}
int row = InputRowCol("Введите количество строк в массиве: ");
int col = InputRowCol("Введите количество колонок в массиве: ");
int[,] array = CreateMatrix(row, col);
PrintArray(array);
Console.WriteLine("Упорядоченный массив:");
PrintArray(ArrangeRow(array));


