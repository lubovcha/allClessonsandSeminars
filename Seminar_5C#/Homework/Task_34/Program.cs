/* 
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int[] GetArray()
{
int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(100, 1000);
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

int CountEvenNumbers(int[] array){
int count = 0;
for (int i = 0; i < array.Length; i++)
{
if(array[i] % 2 == 0 ){
count += 1;
}
}
return count;
}

int[] array = GetArray();
PrintArray(array);
System.Console.WriteLine($"Количество четных чисел в массиве {CountEvenNumbers(array)}");