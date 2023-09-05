/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] array = new int[10];
int evenCounter = 0;

Console.Write("В массиве [ ");  
for (int i = 0; i < 10; i++)
{
    if (i > 0)  Console.Write(", "); 
    array[i] = new Random().Next(100,1000);
    Console.Write(array[i]); 
}
Console.Write(" ], ");  

for (int i = 0; i < 10; i++)
{
    if (array[i] % 2 == 0) {
        evenCounter++;
    }
}

Console.Write(evenCounter + " чётных чисел.");  

