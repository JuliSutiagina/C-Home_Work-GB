// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. Выполнить с помощью рекурсии.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write($"Напилите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write($"Напилите число B: ");
int B = int.Parse(Console.ReadLine()!);




if ((A < 0)|(B < 0))
{
    Console.WriteLine("Какое-то из введенных чисел меньше 0.");
}
else{
    int result = Akkerman(A, B);
    Console.WriteLine($"A({A},{B}) = {result}");
}

int Akkerman(int A, int B){
    if ((A==0)&(B!=0)){
        return B+1;
    }
    if ((A!=0)&(B==0)){
        return Akkerman(A-1, 1);
    }
    else{
        return Akkerman(A-1, Akkerman(A, B-1));
    }
}