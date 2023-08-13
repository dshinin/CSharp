/*
Задача: Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго
*/

Console.WriteLine("Введите два числа: ");

int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber*firstNumber == secondNumber) {
    Console.WriteLine("Первое число (" + firstNumber +") является квадратом второго числа ("+ secondNumber +")");
} else {
    Console.WriteLine("Первое число (" + firstNumber +") не является квадратом второго числа ("+ secondNumber +")");
}

