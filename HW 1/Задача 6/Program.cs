/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
Console.WriteLine("----------------------------------");
Console.Write("Напишите число N: ");
int N = int.Parse(Console.ReadLine()!);
int ostatok = N % 2;
if  (ostatok == 0){Console.WriteLine($"Число {N} - четное");}
else if (ostatok != 0){Console.WriteLine($"Число {N} - нечетное");}
Console.WriteLine("----------------------------------");