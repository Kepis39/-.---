//24 Вариант средний уровень(Арифметические выражения)

//Console.WriteLine("Введите y: ");
//double y = double.Parse(Console.ReadLine());
//Console.WriteLine("Введите k: ");
//double k = double.Parse(Console.ReadLine());
//Console.WriteLine($"U ={(Math.Log(2*k+4.3))/(Math.Exp(k+y)) + Math.Sqrt(y)} ");


//24 Вариант средний уровень(Линейные алгоритмы)

//Console.WriteLine("Введите t: ");
//double t = double.Parse(Console.ReadLine());
//Console.WriteLine("Введите b: ");
//double b = double.Parse(Console.ReadLine());
//double a = Math.Pow(t, 2) + b;
//double x = Math.Pow(a, 3) + Math.Sqrt(t + b);
//double Y = Math.Cos(Math.Pow(x, 5)) - b*Math.Pow(Math.Sin(x),2);
//Console.WriteLine($"y={Y:f2}");

//Целочисленная арифметика задание 3.33

//Console.WriteLine("Введите трехзначное число");
//int x = int.Parse(Console.ReadLine());
//int LastDigit = x % 10;
//int n =  LastDigit * 100 +(x - LastDigit)/10;
//Console.WriteLine($"n = {n}");


//Лабораторная 2
int A = 10, B = 6, C = 7, D = 8;
bool result = (A % 3 == 0 &&(B % 5 == 0 || C % 5 == 0 || D % 5 == 0)) ||
                (B % 3 == 0 && (A % 5 == 0 || C % 5 == 0 || D % 5 == 0)) ||
                (C % 3 == 0 && (A % 5 == 0 || B % 5 == 0 || D % 5 == 0))||
                (D % 3 == 0 && (A % 5 == 0 || B % 5 == 0 || D % 5 == 0));
Console.WriteLine(result);
