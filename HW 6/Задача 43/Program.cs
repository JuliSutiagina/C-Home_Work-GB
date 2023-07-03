// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите коэффициенты для уравнения первой прямой: b1, k1: ");
Console.Write("b1 = ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("k1 = ");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите коэффициенты для уравнения второй прямой: b2, k2: ");
Console.Write("b2 =  ");
double b2 = double.Parse(Console.ReadLine()!);
Console.Write("k2 = ");
double k2 = double.Parse(Console.ReadLine()!);

double x1 = (b2 - b1)/(k1-k2); //Решаем совместно два уравнения и выражаем x1 - абсциссу пересечения двух прямых
double y1 = k1*x1 + b1; // Подставляем найденное значение х в любое уравнение, чтобы получить ординату пересечения
Console.WriteLine($"Точка пересечения двух прямых: ({x1}; {y1})");

