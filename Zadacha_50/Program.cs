// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Enter row number");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter column number");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);
if (n > matrix.GetLength(0) || m > matrix.GetLength(1))
Console.WriteLine("Такого элемента в массиве нет");
else Console.WriteLine($"значение элемента n-й строки и m-го столбца равно: {matrix[n,m-1]}");
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


