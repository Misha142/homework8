// Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.


using System;
using static System.Console;

Clear();

Write("Введите количество строк 1 матрицы: ");
int rows1 = int.Parse(ReadLine()!);

Write("Введите количество столбцов 1 матрицы: ");
int columns1 = int.Parse(ReadLine()!);

Write("Введите количество строк 2 матрицы: ");
int rows2 = int.Parse(ReadLine()!);

Write("Введите количество столбцов 2 матрицы: ");
int columns2 = int.Parse(ReadLine()!);



int[,] array1 = GetArray(rows1, columns1, 0, 10);
int[,] array2 = GetArray(rows2, columns2, 0, 10);

PrintArray(array1);
WriteLine();
PrintArray(array2);
WriteLine();

PrintArray(ProizMatrix(array1, array2));



int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

int[,] ProizMatrix(int[,] inArray1, int[,] inArray2)
{
    int chislo;
    int[,] newArray = new int[inArray1.GetLength(0), inArray2.GetLength(1)];
    if (inArray1.GetLength(1) == inArray2.GetLength(0))
    {

        for (int i = 0; i < newArray.GetLength(0); i++)
        {
            for (int j = 0; j < newArray.GetLength(1); j++)
            {
                newArray[i, j] = 0;
                for (int k = 0; k < inArray1.GetLength(1); k++)
                {
                    newArray[i, j] += inArray1[i, k] * inArray2[k, j];
                }

            }

        }
    }
    return newArray;

}

