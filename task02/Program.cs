/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите два целых числа: ");

int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber) {
    Console.WriteLine("Первое число (" + firstNumber +") больше второго числа ("+ secondNumber +")");
} else if (secondNumber > firstNumber) {
    Console.WriteLine("Второе число (" + secondNumber +") больше первого числа ("+ firstNumber +")");
} else {
    Console.WriteLine("Первое число (" + firstNumber +") и второе число ("+ secondNumber +") равны");
}
