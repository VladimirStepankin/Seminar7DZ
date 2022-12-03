/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.*/ 
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
double[,] numbers = new double[rows, columns];
FillMatrixRandomDouble(numbers);
WriteMatrix(numbers);

void FillMatrixRandomDouble(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] =  RandomDouble(-100,100);
        }
    }
}

double RandomDouble(int min, int max)
{
    return Math.Round(new Random().NextDouble() * (max - min)+ min, 2);
}

void WriteMatrix(double[,] array)
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