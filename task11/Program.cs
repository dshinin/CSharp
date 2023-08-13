/*
Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
*/

int randomNumber = new Random().Next(100,999);

Console.WriteLine("Случайное число: "+randomNumber);

int firstDigit = Convert.ToInt32(randomNumber/100);
int thirddDigit = randomNumber%10;

Console.WriteLine("Удалили вторую цифру: "+firstDigit+thirddDigit);