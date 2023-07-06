// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое* элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// * Сумма всех цифр / их количество(это количество ваших строк)


Console.Write("Введите число строк m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов n: ");
int n = int.Parse(Console.ReadLine()!);
int[,] Arr = GetArr(m, n);
PrintArr(Arr);

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
    Console.WriteLine("Среднее арифметическое по столбцам: ");
    GetAvColumn(arr);

}

void GetAvColumn(int[,] arr){
    double countAv = 0; 
    for (int j = 0; j < arr.GetLength(1); j++){
        for (int i = 0; i < arr.GetLength(0); i++){
            countAv += Convert.ToDouble(arr[i,j])/arr.GetLength(0);
        }
        Console.Write($"{countAv}; ");
        countAv = 0;
    }

}