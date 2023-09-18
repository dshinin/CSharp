/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int Sum;

if (M > N) {
    Sum = SumIntegersInInterval(N, M);
} else {
    Sum = SumIntegersInInterval(M, N);
}

Console.WriteLine("Cумма натуральных чисел в промежутке от M до N: " + Sum);

// 
int SumIntegersInInterval (int M, int N) {
    if (M == N) {
        return M;
    } else {
        return (M + SumIntegersInInterval(M+1, N));
    }
}