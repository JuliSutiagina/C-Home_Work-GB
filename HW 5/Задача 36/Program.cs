// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных ИНДЕКСАХ.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.Write("Введи размер массива size: ");
int size = int.Parse(Console.ReadLine()!);

int[] arr = RandomNumberArray(new int[size]);
int count = CountOddIndexes(arr);

Console.WriteLine($"arr: [{String.Join(", ", arr)}]");
Console.WriteLine($"Cумма элементов, стоящих на нечётных ИНДЕКСАХ: {count}");

// Нахождение суммы элементов на нечетных индексах
int CountOddIndexes(int[] arr){
    int OddCount = 0;
    for(int i = 0; i < arr.Length; i++ ){
        OddCount += i%2 !=0 ? arr[i] : 0;
    }
    return OddCount;
}

//Инициализация массива
int[] RandomNumberArray(int[] arr){
    for(int i =0; i < size; i++){
        arr[i] = new Random().Next(-100, 100);
    }
    return arr;
}
