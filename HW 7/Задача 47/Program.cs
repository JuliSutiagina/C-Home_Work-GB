// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными(тип double) числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Write("Введите число строк m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов n: ");
int n = int.Parse(Console.ReadLine()!);

PrintArr(GetArr(m, n));

double [,] GetArr(int m, int n){
    double [,] arr = new double[m,n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            arr[i, j] = Math.Round(new Random().NextDouble()*(10-(-10))-10, 1);
        }
    }
    return arr;
}

void PrintArr(double[,] arr){
    for (int i = 0; i <arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}