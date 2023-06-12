// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int C = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (A > max)
{
    max = A;
}
if  (B > max)
{
    max = B;
}
if  (C > max)
{
    max = C;
}
Console.WriteLine ("max = " + max);