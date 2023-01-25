// Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);
Console.Write("среднее арифметическое каждого столбца: ");

for (int j = 0; j < matrix.GetLength(1); j++)
{
    double avarageSum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        avarageSum = avarageSum + matrix[i, j];
    }
    avarageSum = avarageSum / 3;
        Console.Write(avarageSum + "; ");
}
Console.WriteLine();
