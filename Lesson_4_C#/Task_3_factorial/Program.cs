double Factorial(int n) //принимает число, факториал которого надо вычислить
{
 // 1! = 1
 // 0! = 1
 if(n == 1) return 1; //если мы дошли до 1, т.е. n=1, то возвращает единицу
 else return n * Factorial(n-1); //в другом случае умножаем на факториал предыдущего числа 
}
for (int i = 1; i < 40; i++)
{
// Console.WriteLine(Factorial(i)); - происходит переполнение типа при больших числах, int -> double
 Console.WriteLine($"{i}! = {Factorial(i)}"); // {i}!
}


