/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

Текст задания и пример ввода-вывода противоречат друг другу: в тексте указано, что вводятся позиции элемента, который надо найти, а в примере ввода-ввывода видно, что вводится число, которое надо найти и, в случае его нахождения, вывести его позиции.

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

Console.WriteLine("Введите искомый элемент: ");
int element = Convert.ToInt32(Console.ReadLine());

// Ищем элемент
bool elementFound = false;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] == element) {
            elementFound = true;
               Console.WriteLine("Элемент со значением " + element + " найден, его позиция: (i = " + i + ", j = " + j + " )"); 
        }
    }
}

if (elementFound == false) {
   Console.WriteLine("Введенного элемента в массиве не обнаружено."); 
}