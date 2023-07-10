// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// 1, 2, 3

// 4, 6, 1

// 2, 1, 6

// 1 встречается 3 раза

// 2 встречается 2 раз

// 3 встречается 1 раз

// 4 встречается 1 раз

// 6 встречается 2 раза


Console.Write($"Напишите размер NxM желаемой матрицы через пробел: ");

string[] arrS = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int n = int.Parse(arrS[0]);
int m = int.Parse(arrS[1]);

int[,] Arr = GetArr(m, n);
PrintArr(Arr);
Console.WriteLine();
CountElemArr(Arr);

int [,] GetArr(int m, int n){
    int [,] arr = new int[m,n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            arr[i, j] = new Random().Next(0,10);
        }
    }
    return arr;
}


void CountElemArr(int[,] arr)
{
    Dictionary<int, int> elemCount = new Dictionary<int, int>();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int element = arr[i, j];

            if (elemCount.ContainsKey(element))
            {
                elemCount[element]++;
            }
            else
            {
                elemCount[element] = 1;
            }
        }
    }

    foreach(var elem in elemCount){
        if ((elem.Value == 2)|(elem.Value == 3)|(elem.Value==4)){
            Console.WriteLine($" Число {elem.Key} встречается {elem.Value} раза");
        }
    else Console.WriteLine($" Число {elem.Key} встречается {elem.Value} раз");
    }
}


void PrintArr(int[,] arr){
    for (int i = 0; i <arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}