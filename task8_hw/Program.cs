// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write ("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int evenA = 2;
if (A > 1)
{
   while (evenA <= A)
   {
    Console.Write (evenA + " ");
    evenA = evenA + 2 ;
   } 
}