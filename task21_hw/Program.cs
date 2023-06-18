// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Возведение в степень
// double number = 9;
// System.Console.WriteLine(Math.Pow(number, 2));

// Извлечение квадратного корня
// System.Console.WriteLine(Math.Sqrt(number));

// Округление дробного числа
// double num = 1.123213213213;
// System.Console.WriteLine(Math.Round(num, 2));

// Комбинация
// System.Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(num, 3)), 2));

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance3D(double Ax, double Ay, double Bx, double By, double Az, double Bz)
{
    double distance = Math.Sqrt(Math.Pow(Ax - Bx, 2) + Math.Pow(Ay - By,2)+ Math.Pow(Az - Bz,2));
    return Math.Round(distance, 2);
}

System.Console.Write("Введите координату Х точки А: ");
double Ax = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y точки А: ");
double Ay = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Z точки А: ");
double Az = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координату Х точки B: ");
double Bx = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y точки B: ");
double By = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Z точки B: ");
double Bz = Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine($"Расстояние между точками A и B равно {Distance3D(Ax, Ay, Bx, By, Az, Bz)}");


