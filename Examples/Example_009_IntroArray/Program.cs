/*
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
                 0   1   2   3   4   5   6  7   8
int[] array = { 11, 21, 31, 41, 15, 61, 71, 8, 19 };

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);

Console.WriteLine(max);
*/
// Поиск индекса элемента массива
/*
int[] array = { 11, 41, 21, 31, 41, 15, 61, 71, 8 };

int n = array.Length;
int find = 41;
int index = 0;
while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
*/
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position]+" ");
        position++;
    }
}
int[] array = new int[10];
FillArray(array);
PrintArray(array);