// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Write("Сколько цифр введете? ");
int[] arr = new int[int.Parse(Console.ReadLine()!)]; //Создаем массив
for (int i = 0; i< arr.Length; i++){
    Console.Write($"{i+1} - ая: ");
    arr[i] = int.Parse(Console.ReadLine()!); //Заполняем массив
}

Console.WriteLine($"[{String.Join(", ", arr)}] -> {MoreThenZero(arr)} из введенных вами больше 0");

int MoreThenZero(int[] arr){
    int count = 0;
    foreach(int i in arr){
        count += i>0 ? 1 : 0; //Проверка, больше ли элемент 0
    }
    return count;

}