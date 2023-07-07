
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillMatrixWithRandom(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} \t");
        }
        System.Console.WriteLine();
    }
}
int FindMinRow(int[,] matrix)
{
  int [] rowSum = new int [matrix.GetLength(0)];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j <matrix.GetLength(1); j++)
    {
      rowSum[i]=rowSum[i]+matrix[i,j];
    }

  }
  int minRow = 0;
  for (int i = 1; i < matrix.GetLength(0); i++)
  {
    if (rowSum[i]<rowSum[minRow])
    {
      minRow=i;
    }
  }
return minRow;
}
System.Console.WriteLine("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];
FillMatrixWithRandom(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();
System.Console.WriteLine($"Минимальная строка под номером: {FindMinRow(matrix)}");