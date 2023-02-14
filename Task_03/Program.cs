// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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





int[,] GetMultArray(int[,] arrayOne, int[,] arrayTwo)
{
    int[,] result = new int[arrayOne.GetLength(0), arrayTwo.GetLength(1)];

    for (int i = 0; i < arrayOne.GetLength(0); i++)

        for (int j = 0; j < arrayOne.GetLength(1); j++)
        {
            for (int k = 0; k < arrayOne.GetLength(1); k++)
                
                result[i, j] += arrayOne[i, k] * arrayTwo[k, j];
        }
        return result;
}



int row = InputRowCol("Введите количество строк первого массива: ");
int col = InputRowCol("Введите количество колонок первого массива: ");
int row2 = InputRowCol("Введите количество строк второго массива: ");
int col2 = InputRowCol("Введите количество колонок второго массива: ");
int[,] array = CreateMatrix(row, col);
int[,] array2 = CreateMatrix(row2, col2);
int[,] resultArrays = GetMultArray(array, array2);
Console.WriteLine("Массив №1");
PrintArray(array);
Console.WriteLine("Массив №2");
PrintArray(array2);
Console.WriteLine("Произведение");
PrintArray(resultArrays);
