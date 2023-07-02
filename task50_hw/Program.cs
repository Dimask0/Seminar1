// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

Console.WriteLine("введите номер строки");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int y = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [4,4];

FillArrayRandomNumbers(numbers);

if (x > numbers.GetLength(0) || y > numbers.GetLength(1))
{
    Console.Write($"такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {x} строки и {y} столбца равно {numbers[x-1,y-1]}");
}

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
