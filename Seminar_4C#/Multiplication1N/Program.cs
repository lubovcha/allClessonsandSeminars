/* 
Напишите программу, которая принимает на вход число N и выдаёт произведение (умножение) чисел от 1 до N.

4  -> 24
5  -> 120
*/

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int GetMultiply(int n){
int result = 1; // переменная, которая будет считать кол-во попыток (счетчик)
for (int i = 2; i <= n; i++) //что бы резузьтат умножался сразу на 2, а не 1*1=1
{
result *= i;
}
return result;
}
System.Console.WriteLine($"Факториал числа {num} равен {GetMultiply(num)}");