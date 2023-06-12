// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int B = Convert.ToInt32(Console.ReadLine());
if (A > B)
{
    System.Console.WriteLine($"A = max ");
}
else
{
    System.Console.WriteLine($"B = max ");
}