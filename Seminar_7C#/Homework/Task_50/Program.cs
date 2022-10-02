/* 
 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
 или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1,7 -> такого числа в массиве нет
*/

 int Prompt(string message)
 {
     System.Console.Write(message);
     int result = Convert.ToInt32(Console.ReadLine());
     return result;
 }

 int[,] GenerateArray(int rows, int colums)
 {
     int[,] array = new int[rows, colums];
     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             array[i, j] = new Random().Next(-10, 11);
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

 bool FindPositinOnArray(int [,]array, int row, int column)
 {
     int searchRow = row-1;
     int searchColumns = column-1;
     bool position = false;
     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             if (i == searchRow && j == searchColumns)
             {
                 position = true;
             }
         }
     }
     return position;
 }

 int rowsOnArray = Prompt("Введите количество строк > ");
 int columnsOnArray = Prompt("Введите количество столбцов > ");
 int[,] NewArray = GenerateArray(rowsOnArray, columnsOnArray);
 PrintArray(NewArray);

 int searchyRow = Prompt("Введите номер строки, в котором нужно найти число в массиве: ");
 int searchyColumn = Prompt("Введите номер столбца, в котором нужно найти число в массиве: ");
 if (FindPositinOnArray(NewArray, searchyRow, searchyColumn))
 {
     Console.WriteLine($"Значение элемента {searchyRow} строки {searchyColumn} столбца = {NewArray[searchyRow-1,searchyColumn-1]}");
 }
 else
 {
     Console.WriteLine("Такого числа в массиве нет");
 }