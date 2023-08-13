/*
Напишите программу, которая принимает на вход два числа и провеяет является ли одно из них квадратом другого
*/

Console.WriteLine("Введите два числа: ");

int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber * secondNumber) {
    Console.WriteLine("Число "+firstNumber+" является квадратом числа "+secondNumber);
} else if (secondNumber == firstNumber * firstNumber) {
    Console.WriteLine("Число "+secondNumber+" является квадратом числа "+firstNumber);
} else {
      Console.WriteLine("Ни одно из введенных чисел не является квадратом друого");  
}
