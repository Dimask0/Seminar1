// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

int SumAll(int number)
{
    int count = Convert.ToString(number).Length;
    int slojn = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
      slojn = number - number % 10;
      result = result + (number - slojn);
      number = number / 10;
    }
   return result;
  }

int Sum = SumAll(number);
Console.WriteLine("Сумма цифр в числе: " + Sum);