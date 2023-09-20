// Task 1. Напишите программу, которая на вход принимает число и выдает его квадрат
/*
Console.WriteLine("Input number: ");
string numberString = Console.ReadLine();
int numberInt = Convert.ToInt32(numberString);
int res = numberInt * numberInt;
Console.WriteLine(res);
*/
// Task 2. 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3, b = 9 -> нет
/*
Console.WriteLine("Input first number: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input second number: ");
int number2 = int.Parse(Console.ReadLine());

if(number1 == number2 * number2)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
*/
// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
	// 3 -> Среда 
    // 5 -> Пятница
/*
Console.WriteLine("Enter week number");
int number = int.Parse(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine("its monday");
}

else if (number == 2)
{
    Console.WriteLine("its tuesday");
}

else if (number == 3)
{
    Console.WriteLine("its wednesday");
}
else if (number == 4)
{
    Console.WriteLine("its thursday");
}
else if (number == 5)
{
    Console.WriteLine("its friday");
}
else if (number == 6)
{
    Console.WriteLine("its saturday");
}
else if (number == 7)
{
    Console.WriteLine("its sunday");
}

else
{
    Console.WriteLine("You are entered not a week number");
}
*/
// 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	// 456 -> 6
	// 782 -> 2
	// 918 -> 8
/*
Console.WriteLine("enter a  number");
int number = int.Parse(Console.ReadLine());

if (number >= 100 && number < 1000)
{
    Console.WriteLine("result is  " + number % 10);

}
else
{
    Console.WriteLine("you are entered wrong number");
}
*/
// 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"
/*
Console.WriteLine("enter a  number");
int number = int.Parse(Console.ReadLine());

int negative = -number;

while (negative <= number)
{
    Console.WriteLine(" number" + negative);
    negative++;
}
*/
