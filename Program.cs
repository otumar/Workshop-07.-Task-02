// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
int[,] GenerateArray(int row, int column, int min, int max)
{
    var array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void FindNumber(int[,] array, int RowPosition, int ColumnPosition)
{
    if (RowPosition > array.GetLength(0) || ColumnPosition > array.GetLength(1))
    {
        System.Console.WriteLine($"На введенной позиции элемента нет");
    }
    else
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[RowPosition - 1, ColumnPosition - 1] == array[i, j])
                {
                    System.Console.WriteLine($"На введенной позиции элемента находится элемент {array[i, j]}");
                    return;
                }

            }

        }
}

int row = Prompt("Введите количество строк: ");
int column = Prompt("Введите количество столбцов: ");
int min = 1;
int max = 10;
int[,] array = GenerateArray(row, column, min, max);
PrintArray(array);
int RowPosition = Prompt("Введите номер строки: ");
int ColumnPosition = Prompt("Введите номер столбца: ");
FindNumber(array, RowPosition, ColumnPosition);