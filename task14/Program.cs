/*
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
*/

Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number%(7*23) == 0) {
    Console.WriteLine("кратно");
} else {
    Console.WriteLine("не кратно");
}