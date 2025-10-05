//24 Вариант средний уровень(Линейные алгоритмы)

Console.WriteLine("Введите t: ");
double t = double.Parse(Console.ReadLine());
Console.WriteLine("Введите b: ");
double b = double.Parse(Console.ReadLine());
double a = Math.Pow(t, 2) + b;
double x = Math.Pow(a, 3) + Math.Sqrt(t + b);
double Y = Math.Cos(Math.Pow(x, 5)) - b*Math.Pow(Math.Sin(x),2);
Console.WriteLine($"y={Y:f2}");
