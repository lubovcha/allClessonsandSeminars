/* 
Напишите программу, которая принимает на вход число N и выдаёт произведение (умножение) чисел от 1 до N.

4  -> 24
5  -> 120
*/

System.Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int GetSum(int limit){ // гетсум = нужно вернуть сумму
int sum = 0; 
for (int i = 1; i <= limit; i++)
{
sum += i; //// sum = +i 
} 
return sum;
}
System.Console.WriteLine($"Сумма чисел от 1 до {n} -> {GetSum(n)}");