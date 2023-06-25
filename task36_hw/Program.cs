// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArrayWithRandomNumber(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 99);
    }
    return arr;
}

System.Console.Write("Введите кол-во элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join("; ", array));

int count = 0;
int SumNegativ = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 1)
    {
        SumNegativ = array[i] + SumNegativ;
        count++;
    }
}
System.Console.Write($"Сумма нечетных элементов в массиве {SumNegativ} ");
