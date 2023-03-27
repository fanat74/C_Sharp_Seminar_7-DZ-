// Задача 52. Задайте двумерный массив из целых чисел. 
// найдите среднее арифметическое элементов в каждом столбце
// что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3



int[,] array2D = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2D);
Sum(array2D);



int[,] CreateMatrixRndInt(int raws, int columns, int min, int max)
{
    int[,] matrix = new int[raws, columns];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],6} ");
        }
        Console.WriteLine("|");
    }
}

void Sum(int[,] matrix)
{
    Console.Write("Среднее арифметическое каждого столбца ");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum=0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum+matrix[i, j];
        }
        if (j<matrix.GetLength(1)-1) Console.Write($"{Math.Round(sum/matrix.GetLength(0), 2)};  ");
        else Console.Write($"{Math.Round(sum/matrix.GetLength(0), 2)}.");
    }
     Console.WriteLine();
}

// if(i<arr.Length-1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");