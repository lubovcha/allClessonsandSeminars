/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/
int[] GetArray()
{
int[] array = new int[4];
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(-10, 11);
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

int SumOddIndexNumbers(int[] array){
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
if(i % 2 != 0 ){
sum += array[i];
}
}
return sum;
}

int[] array = GetArray();
PrintArray(array);
System.Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях в массиве = {SumOddIndexNumbers(array)}");