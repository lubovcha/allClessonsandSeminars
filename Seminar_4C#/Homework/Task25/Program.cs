/* 
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/
System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());

int GetMultiply(int a, int b){ // название мы придумываем сами
int result = 1; // переменная, которая будет считать кол-во попыток (счетчик)
for (int i = 1; i <= b; i++) 
{
result = result *a;
}
return result;
}
System.Console.WriteLine($"Число {a} в натуральной степени {b} -> {GetMultiply(a, b)}");