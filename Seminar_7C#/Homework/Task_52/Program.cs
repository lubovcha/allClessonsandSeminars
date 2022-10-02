/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

 int Prompt(string message)
 {
     System.Console.Write(message);
     int result = Convert.ToInt32(Console.ReadLine());
     return result;
 }

 int[,] GenerateArray(int rows, int columns)
 {
     int[,] array = new int[rows, columns];
     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             array[i, j] = new Random().Next(0, 10);
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

 void FindMeanOnColumnsArray(int[,] matrix)
 {
     double arithmeticMean = 0;
     double sumColumns = 0;

     for (int j = 0; j < matrix.GetLength(1); j++)
     {
         for (int i = 0; i < matrix.GetLength(0); i++)
         {
             sumColumns += matrix[i, j];
         }
         arithmeticMean = sumColumns / matrix.GetLength(0);
         Console.WriteLine($" Среднее арифметическое столбца {j + 1} = {arithmeticMean:F2}");
         sumColumns = 0;
     }
 }

 int rowsOnArray = Prompt("Введите количество строк: ");
 int columnsOnArray = Prompt("Введите количество столбцов: ");
 int[,] myArray = GenerateArray(rowsOnArray, columnsOnArray);
 PrintArray(myArray);
 FindMeanOnColumnsArray(myArray);
