// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int numberPow(int N, int indicator){

    int res = 1;

    for (int i = 1; i <= indicator; i++){
        res *= N;
    }
    return res;
}


Console.Write("Введите число - основание: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите показатель степени: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{A}, {B} -> {numberPow(A, B)}");