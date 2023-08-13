/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine("Введите трехзначное число: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number < 1000 && number >= 100 ) {
    Console.WriteLine("Вторая цифра числа "+number+" = "+(number%100-number%10)/10);
} else {
    Console.WriteLine("Увы, число не трехзначное");
}


