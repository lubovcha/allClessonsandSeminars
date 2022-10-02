/*

Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/

 int Prompt(string message)
 {
     System.Console.Write(message);
     return Convert.ToInt32(Console.ReadLine());
 }

 int SumNaturalNumbers(int start, int stop)
 {
     if (start < stop || start > stop)
     {
         return (start + SumNaturalNumbers(start + 1, stop));
     }
     if (start == stop) return start;
     return start;
 }

 int start = Prompt("Введите первое числое > ");
 int stop = Prompt("Введите второе число > ");
 int result = SumNaturalNumbers(start, stop);
 Console.WriteLine($"Сумма натуральных элементов в промежутке [{start}, {stop}] -> {result}");