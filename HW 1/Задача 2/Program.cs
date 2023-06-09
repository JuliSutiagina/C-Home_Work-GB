/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Требуется ввести два числа a, b ");

Console.Write("Введите a: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите b: ");
int b = int.Parse(Console.ReadLine()!);

if (a > b){
    Console.WriteLine($"Число {a} больше {b}. MAX -> {a}");
}
else if (b > a){
    Console.WriteLine($"Число {b} больше {a}. MAX -> {b}");
}
else{
    Console.WriteLine($"Числа {a} и {b} равны ");
}