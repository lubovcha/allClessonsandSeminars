/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9

*/

int Prompt(string message)
{
     Console.Write(message);
     int result = Convert.ToInt32(Console.ReadLine());
     return result;
 }

double[,] GenerateArray(int rows, int columns)
{
double[,] array = new double[rows, columns];
for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             array[i, j] = new Random().NextDouble() * 20 - 10;
         }
     }
     return array;
 }

 void PrintArray(double[,] matrix)
 {
     for (int i = 0; i < matrix.GetLength(0); i++)
     {
         for (int j = 0; j < matrix.GetLength(1); j++)
         {
             System.Console.Write($"{matrix[i, j]:f1}\t");
         }
         System.Console.WriteLine();
     }
     System.Console.WriteLine();
 }

 int countRows = Prompt("Введите количество строк > ");
 int countColumns = Prompt("Введите количество столбцов > ");
 double[,] myArray = GenerateArray(countRows, countColumns);
 PrintArray(myArray);