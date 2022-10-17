// Задача 61: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

Random random = new Random();
int rowsFirst = random.Next(4, 8);
int columnsFirst = random.Next(4, 8);
int rowsSecond = columnsFirst;
int columnsSecond = random.Next(4, 8);

int[,] firstMatrix = new int[rowsFirst, columnsFirst];
FillArray(firstMatrix);
int[,] secondMatrix = new int[rowsSecond, columnsSecond];
FillArray(secondMatrix);

int n = firstMatrix.GetLength(0);
int[,] result = new int[rowsFirst, columnsSecond];

for (int i = 0; i < rowsFirst; i++)
{
	for (int j = 0; j < columnsSecond; j++)
	{
		for (int k = 0; k < rowsFirst; k++)
		{
			result[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
		}
	}
}
Console.WriteLine("Matrix 1:");
PrintArray(firstMatrix);
Console.WriteLine("Matrix 2:");
PrintArray(secondMatrix);
Console.WriteLine("Matrix multiplication:");
PrintArray(result);



void FillArray(int[,] numbers)
{
	Random random = new Random();
	int rows = numbers.GetLength(0);
	int columns = numbers.GetLength(1);

	for (int i = 0; i < rows; i++)
	{
		for (int j = 0; j < columns; j++)
		{
			numbers[i, j] = random.Next(0, 10);
		}

	}
}

void PrintArray(int[,] numbers)
{
	int rows = numbers.GetLength(0);
	int columns = numbers.GetLength(1);

	for (int i = 0; i < rows; i++)
	{
		for (int j = 0; j < columns; j++)
		{
			Console.Write($"{numbers[i, j]} \t");
		}
		Console.WriteLine();
	}
	Console.WriteLine();
}
