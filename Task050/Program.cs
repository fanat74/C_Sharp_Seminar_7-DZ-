// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите номер строки элемента массива");
int posRawMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца элемента массива");
int posColumnMatrix = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2D);
int check = CheckIndexMatrix(array2D, posRawMatrix, posColumnMatrix);
Console.WriteLine($"Элемент двухмерного массива с индексом [{posRawMatrix}, {posColumnMatrix}] равен {check}");

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

int CheckIndexMatrix(int[,] matrix, int x, int y)
{
    if (x > 3 && y > 4)
    Console.Write("Такого элемента в массиве нет");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

        }
    }
    return matrix[x, y];
}


//не корректно выводит данные в случае выхода индекса за пределы массива
    
