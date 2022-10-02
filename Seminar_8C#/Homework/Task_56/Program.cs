/*
 Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

 int[,] GenerateArray(int rows, int columns, int minRnd, int maxRnd)
 {
     int[,] array = new int[rows, columns];
     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             array[i, j] = new Random().Next(minRnd, maxRnd + 1);
         }
     }
     return array;
 }

 void PrintArray(int[,] matrix)
 {
     for (int i = 0; i < matrix.GetLength(0); i++)
     {
         for (int j = 0; j < matrix.GetLength(1); j++)
         {
             System.Console.Write($"{matrix[i, j]}\t");
         }
         System.Console.WriteLine();
     }
     System.Console.WriteLine();
 }

 int MinSumElementsRow(int[,] array)
 {
     int minRow = 0;
     int sumElementRow = 0;
     int minSumRow = 0;
     for (int j = 0; j < array.GetLength(1); j++)
     {
         minSumRow += array[0, j];
     }
     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int n = 0; n < array.GetLength(1); n++) sumElementRow += array[i, n];
         if (sumElementRow < minSumRow)
         {
             minSumRow = sumElementRow;
             minRow = i;
         }
         sumElementRow = 0;
     }
     return minRow;
 }

 int[,] myarray = GenerateArray(rows: 3, columns: 2, minRnd: 0, maxRnd: 10);
 PrintArray(myarray);
 System.Console.WriteLine($"В данном массиве, строка {MinSumElementsRow(myarray)+1} имеет наименьшую сумму элементов");