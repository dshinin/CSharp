/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int n = 2;
int m = 2;

Console.WriteLine("Будут сгенерированы две матрицы размером "+ n + "x"+ m);

int[,] matrixFirst = new int[m,n]; 
int[,] matrixSecond = new int[m,n]; 

FillRandomIntArray(matrixFirst);
FillRandomIntArray(matrixSecond);
Console.WriteLine("Первая матрица:");
PrintArray(matrixFirst);
Console.WriteLine("Вторая матрица:");
PrintArray(matrixSecond);

int[,] matrixThird = MatrixMultiply(matrixFirst, matrixSecond);
Console.WriteLine("Результат перемножения матриц:");
PrintArray(matrixThird);


// Функция заполняет переданный массив случайными элементами типа Int
void FillRandomIntArray (int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0,10);
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
int[,]  MatrixMultiply (int[,] firstMatrix, int[,] secondMatrix) {

    int [,] resultMatrix = new int[firstMatrix.GetLength(0),secondMatrix.GetLength(1)]; 

    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < resultMatrix.GetLength(0); k++ ) {
                resultMatrix[i,j] = resultMatrix[i,j] + firstMatrix[i,k] * secondMatrix[k,j];
            }
        }
    }

    return resultMatrix;
}

