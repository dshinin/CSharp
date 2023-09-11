﻿/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.WriteLine("Будет сгенерирован массив размером NxM.");
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());


int[,] array = new int[m,n]; 
Random random = new Random();

// Заполняем и сразу выводим
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(0,20);
        Console.Write($" {array[i,j]} ");
    }
        Console.WriteLine();
}

int rowSum = 0;
for (int i = 0; i < array.GetLength(1); i++)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        rowSum = rowSum + array[j,i];
    }
    Console.WriteLine("Сумма элементов в столбце с номером " + i + " равна " + rowSum); 
    rowSum = 0;
}
