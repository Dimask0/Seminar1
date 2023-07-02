// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("введите количество строк");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int y = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[x, y];
FillArrayRandomNumbers(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double middle = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        middle = (middle + numbers[i, j]);
    }
    middle = middle / x;
    Console.Write(middle + "; ");
}
Console.WriteLine();

PrintArray(numbers);



void FillArrayRandomNumbers(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {   
            Random rnd = new Random();     
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rnd.Next(0, 10);
            }   
        }
}


void PrintArray(int[,] matrix)
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

