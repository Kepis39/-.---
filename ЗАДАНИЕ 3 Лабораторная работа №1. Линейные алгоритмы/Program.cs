//Целочисленная арифметика.Задание 3.33

Console.WriteLine("Введите трехзначное число");
int x = int.Parse(Console.ReadLine());
int LastDigit = x % 10;
int n =  LastDigit * 100 +(x - LastDigit)/10;
Console.WriteLine($"n = {n}");

