/*
Напишите программу, которая принимает на вход два числа и выводить, является ли второе числа кратным первому. Если второе число не кратно первому, то выводит остаток от деления
*/

Console.WriteLine("Введите два числа: ");

int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (secondNumber%firstNumber == 0) {
    Console.WriteLine("кратно");
} else {
    Console.WriteLine("не кратно, остаток "+secondNumber%firstNumber);
}