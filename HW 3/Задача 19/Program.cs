// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Напишите пятизначное число N: ");
string N = Console.ReadLine()!;
if (N.Length !=5){
    Console.WriteLine("Не пятизначное число");
}
else{
    if ((N[0] == N[N.Length-1]) && (N[1] == N[N.Length-2])){
        Console.WriteLine($"{N} -> Да");
    }
    else{
        Console.WriteLine($"{N} -> Нет");
    }
}
