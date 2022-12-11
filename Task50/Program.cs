/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int rows = ReadInt("Введите индекс строки: ");
int columns = ReadInt("Введите индекс столбца: ");
int[,] numbers = new int[3, 4];
FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);

if (rows < numbers.GetLength(0) && columns < numbers.GetLength(1))
{
    Console.WriteLine($"Число с индексом {rows};{columns} равно {numbers [rows, columns]}");
}
else 
{
    Console.WriteLine($"Числа с индексом {rows};{columns} в массиве нет");
}

void FillMatrixRandomNumbers(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void WriteMatrix(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
