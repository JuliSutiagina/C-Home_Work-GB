// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write($"Напилите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write($"Напилите число N: ");
int N = int.Parse(Console.ReadLine()!);

if (M <= N){
    Console.WriteLine($"{rekurs(M, N)}");
}
else{
    Console.WriteLine($"M больше N. Поменяем M и N местами ");
    Console.WriteLine($"{rekurs(N, M)}");
}
int rekurs(int M, int N){
    if (M < N){
        return N + rekurs(M, N-1);
    }
    if (M == N){
        return M;
    }
    else{
        return 0;
    }
}