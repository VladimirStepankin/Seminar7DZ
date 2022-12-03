/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.*/

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);
int position = ReadInt("Введите позицию элемента: ");
if (position < 0)
{
    Console.WriteLine("Такой позиции не существует");
    return;
}
int PositionRow = position / 10;
int PositionColum = position % 10;

if (PositionRow > rows - 1 || PositionColum > columns - 1)
{
    Console.WriteLine("Такого элемента не существует");
}
else
{
    Console.WriteLine(numbers[PositionRow, PositionColum]);
}
void FillMatrixRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void WriteMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
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
