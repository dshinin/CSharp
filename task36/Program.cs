/*
 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] array = new int[10];
int summator= 0;

Console.Write("В массиве [ ");  
for (int i = 0; i < 10; i++)
{
    if (i > 0)  Console.Write(", "); 
    array[i] = new Random().Next(-100,100);
    Console.Write(array[i]); 
}
Console.Write(" ], ");  

for (int i = 0; i < 10; i++)
{
    if (i % 2 != 0) {
        summator = summator + array[i];
    }
}

Console.Write("сумма элементов, стоящих на нечётных позициях = " + summator);  

