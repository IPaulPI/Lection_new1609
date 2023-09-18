// Task 1. Напишите программу, которая на вход принимает число и выдает его квадрат
Console.WriteLine("Input number: ");
string numberString = Console.ReadLine();
int numberInt = Convert.ToInt32(numberString);
int res = numberInt * numberInt;
Console.WriteLine(res);