/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double Prompt(string message)
{
Console.Write(message);
double result = Convert.ToDouble(Console.ReadLine());
return result;
}

double b1 = Prompt("значения b1: ");
double k1 = Prompt("значения k1: ");
double b2 = Prompt("значения b2: ");
double k2 = Prompt("значения k2: ");
System.Console.WriteLine();
double х = (b2 - b1) / (k1 - k2);
double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;

bool Coordinate(double k1, double k2)
{
if(k1 != k2)
{
return true;
}
return false;
}

if (Coordinate(k1, k2))
{
Console.WriteLine($"прямые имеют точку пересечения ({х:f1} ; {y:f1})"); // :f2 - определям количество знаков после запятой
}
else
{
if (b1 == b2)
{
Console.WriteLine("прямые совпадают");
}
else
{
Console.WriteLine("прямые параллельны");
}
}