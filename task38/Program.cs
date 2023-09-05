/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

double[] array = {3.22, 4.2, 1.15, 77.15, 65.2};
double max;
double min;

max = array[0];
min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array [i]; 
    if (array[i] < min) min = array [i]; 
}

Console.Write(max + " - " + min + " = " + (max-min));  

