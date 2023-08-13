/*
Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
*/

int randomNumber = new Random().Next(10,99);

Console.WriteLine("Случайное число: "+randomNumber);

int firstDigit = Convert.ToInt32(randomNumber/10);
int secondDigit = randomNumber%10;


if (firstDigit > secondDigit) {
    Console.WriteLine("Наибольшая цифра: "+firstDigit);
} else {
        Console.WriteLine("Наибольшая цифра: "+secondDigit);
}