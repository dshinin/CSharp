﻿/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/


Console.WriteLine("Введите число N: ");

int Number = Convert.ToInt32(Console.ReadLine());
PrintPreviousInteger (Number);

void PrintPreviousInteger (int number) {
    if (number == 1) {
        Console.Write(number);
    } else {
        Console.Write(number+ ", ");
        PrintPreviousInteger(number-1);
    }
}