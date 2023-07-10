// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write($"Напишите размер NxM желаемой матрицы через пробел: ");

string[] arrS = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int n = int.Parse(arrS[0]);
int m = int.Parse(arrS[1]);

int[,] Arr = GetArr(m, n);
PrintArr(Arr);
Console.WriteLine("Отсортированная по убыванию элементов в строках матрица: ");
PrintArr(SortArr(Arr));


int [,] GetArr(int m, int n){
    int [,] arr = new int[m,n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            arr[i, j] = new Random().Next(0,10);
        }
    }
    return arr;
}


int[,] SortArr(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++){ 
        for (int j = 0; j < arr.GetLength(1) - 1; j++){
            for (int pos = j + 1; pos < arr.GetLength(1); pos++){
                if (arr[i,j] < arr[i, pos]){
                    int temp = arr[i, j];
                    arr[i, j] = arr[i, pos];
                    arr[i, pos] = temp;
                }
                else {
                    continue;
                    }
            }   
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