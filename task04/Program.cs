/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите три целых числа: ");

int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int maxNumber = firstNumber;

Console.Write("Самое большое из введенных вам чисел: ");

if (secondNumber > maxNumber ) {
    maxNumber = secondNumber;
}
if (thirdNumber > maxNumber ) {
    maxNumber = thirdNumber;
}

Console.WriteLine(maxNumber);
