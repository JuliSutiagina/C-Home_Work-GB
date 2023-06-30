// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

Console.Write("Введи размер массива size: ");
int size = int.Parse(Console.ReadLine()!);

int[] arr = RandomNumberArray(new int[size]);
int count = CountEvenNumber(arr);

Console.WriteLine($"arr: [{String.Join(", ", arr)}]");
Console.WriteLine($"Колличество четных чисел: {count}");

//Подсчет количества четных элементов
int CountEvenNumber(int[] arr){
    int EvenCount = 0;
    foreach(int i in arr){
        EvenCount += i%2 ==0 ? 1 : 0;
    }
    return EvenCount;
}

//Инициализация массива
int[] RandomNumberArray(int[] arr){
    for(int i =0; i < size; i++){
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}
