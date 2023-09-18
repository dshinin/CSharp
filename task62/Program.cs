/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


int[,] array = new int[4,4]; 
int pointerI = 0;
int pointerJ = 0;
int deltaJ = 1;
int deltaI = 0;
int value = 1;
bool isMoveAllowed;

// Делаем столько шагов, сколько всего элементов в массиве
for (int i =0; i< (array.GetLength(0) * array.GetLength(1)); i++) {

    // Заполняем значение, а следующее будет больше на 1
    array[pointerI, pointerJ] = value;
    value++;

    isMoveAllowed = true;

    // Теперь проверяем, можем мы сделать шаг в нужном направлении
    // Нам может препятствовать два случая:
    // - выход за границы массива,
    // - то место уже заполнено

    // Проверяем выход за границы массива

    // За правую или левую
    if ((pointerJ + deltaJ >= array.GetLength(1)) | (pointerJ + deltaJ < 0)) {
        isMoveAllowed = false;
    }

    // За верхнюю или нижнюю
    if ((pointerI + deltaI >= array.GetLength(0)) | (pointerI + deltaI < 0)) {
        isMoveAllowed = false;
    }

    // Затем, если мы не выходим за границы массива,
    // проверяем не заполнено ли уже следующее поле
    if (isMoveAllowed) {
        if (array[pointerI+deltaI, pointerJ+deltaJ] != 0) {
            isMoveAllowed = false;
        }
    }

    // Если шаг сделать нельзя, надо поворачивать, т.е. изменять значения delta
    if (isMoveAllowed == false) {
        if (deltaI == 0 & deltaJ == 1) {
            deltaI = 1;
            deltaJ = 0;
        } else if (deltaI == 1 & deltaJ == 0) {
            deltaI = 0;
            deltaJ = -1;
        } else if (deltaI == 0 & deltaJ == -1) {
            deltaI = -1;
            deltaJ = 0;
        } else if (deltaI == -1 & deltaJ == 0) {
            deltaI = 0;
            deltaJ = 1;
        }
    }

    // Делаем шаг
    pointerI = pointerI + deltaI;
    pointerJ = pointerJ + deltaJ;
}


PrintArray(array);


// Функция выводит переданный массив
void PrintArray (int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,0:D2} ", array[i,j]);
        }
            Console.WriteLine();
    }
}