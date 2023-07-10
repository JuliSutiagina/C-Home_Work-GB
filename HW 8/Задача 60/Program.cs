// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int m = 2;
int n = 2;
int k = 2;

int[,,] arr = GetArr(m,n,k);
PrintArr(arr);


int [,,] GetArr(int m, int n, int p){
    int [,,] arr = new int[m,n,p];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            for (int k = 0; k < arr.GetLength(2);k++){
                int num;
                do{
                    num = new Random().Next(10, 100);
                }while(Contains(arr, num));
                arr[i,j,k] = num;
            }

        }
    }
    return arr;
}

bool Contains(int[,,] array, int num)
    {
        foreach (int element in array)
        {
            if (element == num)
            {
                return true;
            }
        }
        return false;
    }




void PrintArr(int[,,] arr){
    for (int i = 0; i <arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            for (int k = 0; k <arr.GetLength(2); k++){
                Console.Write($"{arr[i,j, k]}({i},{j},{k}) ");
            }

        }
        Console.WriteLine();
    }
}