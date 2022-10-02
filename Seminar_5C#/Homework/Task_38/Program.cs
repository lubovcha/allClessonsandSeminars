/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
int[] GetArray(int size)
{
int [] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(-1, 100);
}
return array;
}

void PrintArray(int[] array)
{
System.Console.Write("[");
for (int i = 0; i < array.Length - 1; i++)
{
System.Console.Write(array[i] + ", ");
}
System.Console.WriteLine(array[array.Length-1] + "]");
}

int FindMin(int[] array){
int min = array[0];
for (int i = 1; i < array.Length; i++)
{
if(array[i] < min){
min = array[i];
}
}
return min;
}

int FindMax(int[] array){
int max = array[0];
for (int i = 1; i < array.Length; i++)
{
if(array[i] > max){
max = array[i];
}
}
return max;
}

int [] array = GetArray(5);
PrintArray(array);
int minPosition = FindMin(array);
int maxPosition = FindMax(array);
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {maxPosition - minPosition}");

