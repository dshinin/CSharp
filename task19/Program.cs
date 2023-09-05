/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.WriteLine("Введите пятизначное число: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number <= 99999 & number >= 10000) {

    int digit_pos_1 = number % 10;
    int digit_pos_2 = (number % 100 - digit_pos_1) / 10;
    int digit_pos_5 = (number / 10000); 
    int digit_pos_4 = (number / 1000) - digit_pos_5 * 10;

    if (digit_pos_1 == digit_pos_5 & digit_pos_2 == digit_pos_4) {
        Console.WriteLine("Да, число является палиндромом.");
    } else {
        Console.WriteLine("Нет, число не является палиндромом."); 
    }
} else {
    Console.WriteLine("Введенное число не пятизначное.");
}

