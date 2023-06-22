// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int numberSum (int N){
    int sumN = 0;
    while (N > 0){
        sumN += N%10;
        N /=10;
    }
    return sumN;
}

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{N} -> {numberSum(N)}");