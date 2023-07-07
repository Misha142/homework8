
using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine()!);

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine()!);

Write("Введите глубину массива: ");
int depth = int.Parse(ReadLine()!);



int[,,] array = GetArray(rows, columns, depth, 10, 100);


PrintArray(array);

// не сделал условие про неповторяющиеся значения по причине того, что слишком просто сделать массив в котором больше чем 89 символов
int[,,] GetArray(int m, int n, int o, int minValue, int maxValue)
{
    int[,,] result = new int[o, m, n];
    for (int i = 0; i < o; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int k = 0; k < n; k++)
            {
                result[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return result;
}
void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            WriteLine();
            for (int k = 0; k < inArray.GetLength(2); k++)
            {


                Write($"{inArray[i, j, k]}({i}{j}{k}) ");
            }

        }

    }
}

