/*
Задача 8: Напишите программу, которая на вход принимает трехзначное число, а на выходе показывает последнюю цифру этого числа
*/
Console.WriteLine("Введите трехзначное число: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number < 1000 && number >= 100 ) {
    Console.WriteLine("Третья цифра числа "+number+" = "+number%10);
} else {
    Console.WriteLine("Увы, число не трехзначное");
}


