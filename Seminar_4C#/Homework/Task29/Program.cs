/*
 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
int[] GetArray()
{
int[] result = new int[8];
for (int i = 0; i < result.Length; i++)
{
result[i] = new Random().Next(100);
}

return result;
}

void PrintArray(int[] arr)
{
int i = 0;
Console.Write("[");
while (i < arr.Length)
{
Console.Write(arr[i]);
i++;
if (i < arr.Length)
{
 Console.Write(", ");
}
}
Console.Write("]");
}

PrintArray(GetArray());