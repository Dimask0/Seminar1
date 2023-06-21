//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// int [] numbers = new int[8];
// Console.Write("[");

// for (int i = 0; i < numbers.Length; i++)
//  {
//     numbers [i] = new Random().Next(0, 33);
//     Console.Write(" " + Massiv (i) + " ");
//  }
// Console.Write("]");
// int Massiv (int a)
// {
//     return numbers[a];
// }

int[] arr = new int[8];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(0, 33);
}

System.Console.WriteLine($"[{string.Join("; ", arr)}]");