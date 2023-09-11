/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
ArraySortRow(array);
Console.WriteLine("Массив с отсортированными строками:");
PrintArray(array);


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

// Функция сортирует строки массива по убыванию
void ArraySortRow (int[,] array) {
    int indexMaximum = 0;
    int maximum = 0;
    int buffer = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            maximum = array[i,j];
            indexMaximum = j;
            // Находим максимальный элемент в строке, начиная с текущей позиции
            for (int j2 = j; j2 < array.GetLength(1); j2++) {
                if (array[i,j2] > maximum) {
                    indexMaximum = j2;
                    maximum = array[i,j2];
                }
            }
            // Если нашли большее число, меняем местами
            if (indexMaximum != j) {
                buffer = array[i,j];
                array[i,j] = array[i,indexMaximum];
                array[i,indexMaximum] = buffer;
            }
        }
    }    
} 

