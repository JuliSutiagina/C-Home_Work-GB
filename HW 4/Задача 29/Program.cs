// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (можно указать любой промежуток)
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] Massiv(int size){
    int[] result = new int[size];
    for (int i = 0; i < size; i++){
        result[i] = new Random().Next(10, 1000);
    }
    return result;
}

Console.Write("Укажите размер массива: ");
int Size = int.Parse(Console.ReadLine()!);
int [] arr = Massiv(Size);
Console.WriteLine($"Массив размера {Size} -> [{String.Join(", ", arr)}]");