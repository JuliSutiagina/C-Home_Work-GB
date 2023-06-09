/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.WriteLine("-------------------------------");
Console.WriteLine("Требуется ввести три числа a, b, c ");
Console.Write("Введите a: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите b: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите c: ");
int c = int.Parse(Console.ReadLine()!);

int max_num = -99999999;
if (a >= max_num){
    max_num = a;
    }
if (b >= max_num){
    max_num = b;
    }
if (c >= max_num){
    max_num = c;
    }
Console.WriteLine($"Максимальное число: {max_num}");
Console.WriteLine("-------------------------------");