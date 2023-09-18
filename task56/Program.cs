/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.WriteLine("Будет сгенерирован массив размером NxM.");
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m,n]; 

FillRandomIntArray(array);
Console.WriteLine("Исходный массив:");
PrintArray(array);
int numRowWithMinSum = FintMinRowSum(array);
Console.WriteLine("Строка с наименьшей суммой элементов: "+(numRowWithMinSum+1));

// Функция заполняет переданный массив случайными элементами типа Int
void FillRandomIntArray (int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0,50);
        }
    }
}

// Функция выводит переданный массив
void PrintArray (int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i,j]} ");
        }
            Console.WriteLine();
    }
}

// Функция возвращает номер строки массива с минимальной суммой элементов
int  FintMinRowSum (int[,] array) {
    int rowMinSumindex = 0;
    int rowMinSum = 0;
    int rowSum;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        rowSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSum = rowSum + array[i,j];
        }

        if (i == 0) {
            rowMinSum = rowSum;
        }

        if (rowSum < rowMinSum) {
            rowMinSum = rowSum;
            rowMinSumindex = i;
        }
    }    
    return rowMinSumindex;
}

