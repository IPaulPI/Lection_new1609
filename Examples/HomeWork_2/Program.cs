// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
/*
Console.WriteLine("Input three digit number");
int number = Convert.ToInt32(Console.ReadLine());
int num1 = number / 10;
int secondDigit = num1 % 10;
Console.WriteLine(secondDigit);
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
/*
int ThirdDigit(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

bool ValidateNumber(int number)
{
    if(number < 100)
    {
        Console.WriteLine("there is no third digit.");
        return false;
    }
    return true;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
if(ValidateNumber(number))
{
    Console.WriteLine(ThirdDigit(number));
}
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
/*
Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number >= 1 && number <=5)
{
    Console.WriteLine("No");
}
else if(number == 6 || number == 7)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("Enter another number");
}
*/

using System;

class Answer
{
    public bool IsPalindrome(int number)
    {
        string numberStr = number.ToString();

        if (numberStr.Length != 5)
        {
            Console.WriteLine("Число не пятизначное");
            return false;
        }

        int length = numberStr.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (numberStr[i] != numberStr[length - i - 1])
            {
                return false;
            }
        }

        return true;
    }
}