/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Введите любое количество чисел, разделенных запятой: ");
string numbersString = Console.ReadLine();

if (numbersString != "") {
    string[] numbers = numbersString.Split(",");
    int[] intNumbers = new int[numbers.Length];

    int numberOfNumberGT0 = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        int number = Convert.ToInt32(numbers[i]);
        if (number > 0) {
            numberOfNumberGT0++;
        }
    }

    Console.WriteLine("Вы ввели "+ numberOfNumberGT0+" чисел больше 0");
} else {
     Console.WriteLine("Вы ничего не ввели");   
}


