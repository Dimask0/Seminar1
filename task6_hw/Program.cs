// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write ("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int remDiv = A % 2;
if (remDiv == 0)
{
    Console.WriteLine ("Да");
}
else
{
    Console.WriteLine ("Нет");
}