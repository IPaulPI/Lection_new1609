// Task 24. Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
/*
int ReadNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int SumFrom1toA(int a)
{
    int sum = 0;
    for(int i = 1; i <= a; i++)
    {
        sum += i; // sum = sum + i
    }
    return sum;
}

int number = ReadNumber("Enter number: ");
if(number > 1)
{
int result = SumFrom1toA(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {result}");
}
else
{
    Console.WriteLine("Ошибка ввода. Введите число больше единицы.")
}
*/
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; // обязательно задать размер массива при инициализации

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input a length of an array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
WriteArray(myArray);