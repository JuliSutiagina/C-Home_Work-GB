// Доп.Задача Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1. (Решить можно, если хотите потренироваться)
// (Следующее число складывается из двух предыдущих)

// Если N = 5 -> 0 1 1 2 3

// Если N = 3 -> 0 1 1

// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите, сколько чисел Фибоначчи хотите вывести: ");
int N = int.Parse(Console.ReadLine()!);
string Fibonach = "0 1"; // Начальные числа Фибоначчи - 0 и 1

while (Fibonach.Split(' ').Length < N) { // Проверяем, сколько чисел уже выведено
    string[] nums = Fibonach.Split(' '); 
    int prev1 = int.Parse(nums[nums.Length - 2]); // Предпоследнее число
    int prev2 = int.Parse(nums[nums.Length - 1]); // Последнее число
    int sum = prev1 + prev2; // Новое число, которое слагается из двух предыдущих
    Fibonach += " " + Convert.ToString(sum); // Добавляем новое число в строку
}

Console.WriteLine($"Если N = {N} -> {Fibonach}");