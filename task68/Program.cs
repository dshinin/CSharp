/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int akkermanResult;

akkermanResult = Akkerman(M, N);

Console.WriteLine("A(m,n) = " + akkermanResult);

// 
int Akkerman (int a, int b) {
    if (a == 0) {
        return b + 1;
    } else if (a > 0 & b == 0) {
        return Akkerman(a - 1, 1);
    } else {
        return Akkerman(a - 1, Akkerman(a, b - 1));
    }
}