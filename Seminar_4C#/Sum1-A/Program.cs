/* 
Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А
7 -> 28
4 -> 10
8 -> 36
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