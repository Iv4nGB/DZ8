// Задача 58: Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int rows = 4;
int columns = 4;
int[,] numbers = new int[rows, columns];

int index = 0;
int currentRow = 0;
int currentColumn = 0;

int changeIndexRow = 0;
int changeIndexColumn = 1;

int steps = columns;
int turn = 0;

while (index < numbers.Length)
{
	numbers[currentRow, currentColumn] = index + 1;
	// Console.Write(numbers[currentRow, currentColumn] + " ");
	index++;
	steps--;

	if (steps == 0)
	{
		steps = rows * ((turn + 1) % 2) + columns * (turn % 2) - 1 - turn / 2;
		int temp = changeIndexRow;
		changeIndexRow = changeIndexColumn;
		changeIndexColumn = -temp;
		turn++;
	}

	currentRow += changeIndexRow;
	currentColumn += changeIndexColumn;
}
PrintArray(numbers);

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
