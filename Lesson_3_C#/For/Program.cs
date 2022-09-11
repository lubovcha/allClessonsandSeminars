/*
string Method4(int count, string text)
{
string result = String.Empty;
for(int i = 0; i < count; i++)
{
    result = result + text;
}
return result;
}
string res = Method4 (10, "z");
Console.WriteLine(res); 
*/

// Цикл в цикле. Задача - вывод таблицы умножения на экран
for (int i = 2; i <= 10; i++) // таблица умножения начинается с 2, i = внешний счетчик
{
   for (int j = 2; j <= 10; j++) // j = внутренний счетчик
   {
    Console.WriteLine($"{i} х {j} = {i * j}");
   }
   System.Console.WriteLine();
}