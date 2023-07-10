// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int [,] arr = new int[4,4];
int n = arr.GetLength(0);
FillSpiralArray(arr);
PrintArr(arr);


void FillSpiralArray(int[,] array){
    int n = array.GetLength(0);
    int value = 1;
    int row = 0;
    int col = 0;
    int rowLimit = n;
    int colLimit = n;

    while (value <= n * n)
    {
        // Вправо
        for (int i = col; i < colLimit; i++)
        {
            array[row, i] = value;
            value++;
        }
        row++;

        // Вниз
        for (int i = row; i < rowLimit; i++)
        {
            array[i, colLimit - 1] = value;
            value++;
        }
        colLimit--;

        // Влево
        if (row < rowLimit)
        {
            for (int i = colLimit - 1; i >= col; i--){
                array[rowLimit - 1, i] = value;
            value++;
            }
            rowLimit--;
        }
        // Вверх
        if (col < colLimit)
        {
            for (int i = rowLimit - 1; i >= row; i--)
            {
                array[i, col] = value;
                value++;
            }
            col++;
        }
    }
}

void PrintArr(int[,] arr){
    for (int i = 0; i <arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
                Console.Write($"{arr[i,j]:D2} ");
            }
        Console.WriteLine();
    }

}
