// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// 1, 2, 3

// 4, 6, 1

// 2, 1, 6

// 1 встречается 3 раза

// 2 встречается 2 раз

// 3 встречается 1 раз

// 4 встречается 1 раз

// 6 встречается 2 раза


Console.Write($"Напишите размер NxM желаемой матрицы A через пробел: ");
string[] arrS_A = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int m_A = int.Parse(arrS_A[0]);
int n_A = int.Parse(arrS_A[1]);


Console.Write($"Напишите размер NxM желаемой матрицы B через пробел: ");
string[] arrS_B = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int m_B = int.Parse(arrS_B[0]);
int n_B = int.Parse(arrS_B[1]);
if (n_A==m_B) {
    int[,] Arr_A = GetArr(m_A, n_A);
    int[,] Arr_B = GetArr(m_B, n_B);
    Console.WriteLine("Матрица А");
    PrintArr(Arr_A);
    Console.WriteLine();
    Console.WriteLine("Матрица В");
    PrintArr(Arr_B);
    Console.WriteLine();
    Console.WriteLine("Матрица C = АxB");
    PrintArr(MultiplyArr(Arr_A, Arr_B));
} 
else{
    Console.WriteLine($"Невозможно перемножить матрицы размером {m_A}x{n_A} и {m_B}x{n_B}. Число столбцов первой матрицы должно ровняться числу строк второй матрицы");
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


int[,] MultiplyArr(int[,] A, int[,] B){
    int[,] C = new int[A.GetLength(0),B.GetLength(1)];
    for (int i = 0; i < A.GetLength(0); i++){
        for(int k = 0; k < B.GetLength(1);k++){
            for (int j = 0; j < A.GetLength(1); j++){
                C[i,k]+=(A[i,j]*B[j,k]);
            }
        }
    }
    return C;
}


void PrintArr(int[,] arr){
    for (int i = 0; i <arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}