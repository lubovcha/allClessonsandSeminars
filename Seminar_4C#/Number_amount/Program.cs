/*
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

456 -> 3

78 -> 2

89126 -> 5
*/

Console.Write("Введи число: ");
int n = Convert.ToInt32(Console.ReadLine());

int CountDigits (int number){ // называем CountDigits, имя метода мы называем сами, как хотим
/*
 int counter = 0; // переменная-счетчик
while (number > 0) //пока кол-во чисел больше 0
{
    number /= 10; // будем делить на 10, тоже самое, что и number = number / 10
    counter++;
}
return counter;
*/
int i = 0;
for (i = 0; number > 0; i++)
{
number /= 10;
}
return i;
}
System.Console.WriteLine(CountDigits(n));