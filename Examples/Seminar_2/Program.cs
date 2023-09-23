// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8
/*
int number = Random.Shared.Next(10, 100);
Console.WriteLine(number);
int lastDigit = number % 10;
int firstDigit = number / 10;

if (firstDigit > lastDigit)
{
    Console.WriteLine($"Первая цифра больше второй. Наибольшая цифра = {firstDigit});
}
else if(firstDigit < lastDigit)
{
    Console.WriteLine("Вторая цифра больше первой. Наибольшая цифра = " + lastDigit);
}
else
{
    Console.WriteLine("Цифры равны");
}
*/
// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98
/*
int number = Random.Shared.Next(100, 1000);
Console.WriteLine(number);
int lastDigit = number % 10;
int firstDigit = number / 100;
int result = firstDigit * 10 + lastDigit;
Console.WriteLine(result);
*/

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно
/*
Console.WriteLine("enter 1st number");
int number1 = int.Parse(Console.ReadLine());


Console.WriteLine("enter 2nd number");
int number2 = int.Parse(Console.ReadLine());


if (number1 % number2 == 0)
{
    Console.WriteLine("number1 is multiple of number2");
}
else
{
    Console.WriteLine($"number is not  multiple {number1 % number2}");
}
*/

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да
/*
Console.WriteLine("Введите число");
int numb = int.Parse(Console.ReadLine());

if(numb%7==0&&numb%23==0)
{
    Console.WriteLine("Число кратно 7 и 23");
}
else
{
    Console.WriteLine("Число не кратно 7 и 23");
}
*/

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        if (!int.TryParse(Console.ReadLine(), out int num1))
        {
            Console.WriteLine("Ошибка ввода для первого числа. Введите целое число.");
            return;
        }

        Console.Write("Введите второе число: ");
        if (!int.TryParse(Console.ReadLine(), out int num2))
        {
            Console.WriteLine("Ошибка ввода для второго числа. Введите целое число.");
            return;
        }

        bool isSquare = false;

        if (num1 != 0 && num2 != 0)
        {
            int sqrtNum1 = (int)Math.Sqrt(num1);
            int sqrtNum2 = (int)Math.Sqrt(num2);

            if (sqrtNum1 == num2 || sqrtNum2 == num1)
            {
                isSquare = true;
            }
        }

        if (isSquare)
        {
            Console.WriteLine("Одно число является квадратом другого.");
        }
        else
        {
            Console.WriteLine("Ни одно из чисел не является квадратом другого.");
        }
    }
}

/*
Console.WriteLine("Input first number");
double num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
double num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2*num2 || num2 == num1*num1)
{
    Console.WriteLine("Одно из чисел является квадратом другого.");
}
else
{
    Console.WriteLine("Ни одно из чисел не является квадратом другого.");
}
*/