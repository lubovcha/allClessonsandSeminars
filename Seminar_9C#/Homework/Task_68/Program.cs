/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

 int Prompt(string message)
 {
     System.Console.Write(message);
     return Convert.ToInt32(Console.ReadLine());
 }

 bool Ackermann(int numberM, int numberN)
 {
     if (numberM > -1 && numberM < 4)
     {
         if (numberN > -1 && numberN < 4)
         {
             return true;
         }
     }
     return false;
 }

 int AckermannFunction(int numberM, int numberN)
 {
     if (numberM == 0) return numberN + 1;
     if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
     if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
     return AckermannFunction(numberM, numberN);
 }

 System.Console.WriteLine("Введите положительные числа m и n для вычисления функции Аккермана");
 int numM = Prompt("Введите число m > ");
 int numN = Prompt("Введите число n > ");
 if (Ackermann(numM, numN))
 {
     int result = AckermannFunction(numM, numN);
     Console.WriteLine($"Функция Аккермана для чисел A({numM},{numN}) = {result}");
 }
 else
 {
     System.Console.WriteLine("Oups, you've broken the function");
 }