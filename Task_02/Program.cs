// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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


int SearchMinSum(int[,] array)
{
    int indexMinRow = 0;
    int min = int.MaxValue;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < min)
        {
            min = sum;
            indexMinRow = i;
        }

    }
    return indexMinRow + 1;
}

int row = InputRowCol("Введите количество строк в массиве: ");
int col = InputRowCol("Введите количество колонок в массиве: ");
int[,] array = CreateMatrix(row, col);
PrintArray(array);
Console.WriteLine($"Строка с наименьшей суммой: {SearchMinSum(array)}");
