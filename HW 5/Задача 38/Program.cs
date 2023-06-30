// Задача 38: Задайте массив целых двухзначных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [22, 42, 15, 77, 65] => 77 - 15 = 62


Console.Write("Введи размер массива size: ");
int size = int.Parse(Console.ReadLine()!);

int[] arr = RandomNumberArray(new int[size]);
int Max = FindMax(arr);
int Min = FindMin(arr);

Console.WriteLine($"arr: [{String.Join(", ", arr)}], Max = {Max}, Min = {Min}, Difference = {Max - Min}");


//Нахлждение максимума
int FindMax(int[] arr){
    int max = -9999999;
    foreach(int i in arr){
        max = i > max ? i : max;
    }
    return max;
}

//Нахлждение минимума
int FindMin(int[] arr){
    int min = 9999999;
    foreach(int i in arr){
        min = i < min ? i : min;
    }
    return min;
}


//Инициализация массива

int[] RandomNumberArray(int[] arr){
    for(int i =0; i < size; i++){
        arr[i] = new Random().Next(-100, 100);
    }
    return arr;
}
