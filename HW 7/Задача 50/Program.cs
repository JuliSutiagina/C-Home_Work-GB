// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными(тип double) числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.Write("Введите число строк m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов n: ");
int n = int.Parse(Console.ReadLine()!);
int[,] Arr = GetArr(m, n);
PrintArr(Arr);

Console.Write("Введите индексы элемента через пробел: ");
string[] arrS = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int i = int.Parse(arrS[0]);
int j = int.Parse(arrS[1]);

if (((i < Arr.GetLength(0)) & (i >= 0)) & ((j < Arr.GetLength(1)) & (j >= 0))){
    Console.WriteLine($"i = {i}, j = {j} -> {Arr[i,j]}");
}
else{
    Console.WriteLine($"Нет элемента с индексами: i = {i}, j = {j}");
}

int [,] GetArr(int m, int n){
    int [,] arr = new int[m,n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            arr[i, j] = new Random().Next(0,10);
        }
    }
    return arr;
}


void PrintArr(int[,] arr){
    for (int i = 0; i <arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}