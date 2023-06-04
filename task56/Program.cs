// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int rows = ReadInt("Введите количество строк и нажмите Enter: ");
int columns = ReadInt("Введите количество столбцов и нажмите Enter: ");
int[,] arr = new int[rows, columns];
int[,] secondArr = new int[rows, columns];
int[,] resultArr= new int[rows, columns];

FillArrayRandom(arr);
PrintArray2D(arr);

Console.WriteLine();

FillArrayRandom(secondArr);
PrintArray2D(secondArray);

Console.WriteLine();

if (array.GetLength(0) != secondArr.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < secondArr.GetLength(1); j++)
    {
        resultArr[i, j] = 0;
        for (int k = 0; k < arr.GetLength(1); k++)
        {
            resultArr[i, j] += arr[i, k] * secondArr[k, j];
        }
    }
}

PrintArray2D(resultArr);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandom(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}