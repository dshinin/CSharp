/*
Задача: Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N
*/

Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

for (int i = number * (-1); i <= number ; i++) {
    if (i > number * (-1)) {
        Console.Write(", ");   
    }
    Console.Write(i);
}






