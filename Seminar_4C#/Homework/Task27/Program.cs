/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

  int GetSum(int numberN){
    int counter = Convert.ToString(numberN).Length; //присваиваем счетчик = длинне цифры
    int n = 0;
    int result = 0;
    for (int i = 0; i < counter; i++){ // i < counter = пока i меньше 4 (0,1,2), если <= то будет (0,1,2,3)
      n = numberN - numberN % 10; // n = 452 - (452 % 10 = 2) = 450; 45 - (45 % 10 = 5) = 40; = 4 - (4 % 10 = 4) = 0
      result = result + (numberN - n); // result = 0 + (452 - 450 = 2) = 2; = 2 + (45 - 40 = 5) = 7; = 7 + (4 - 0 = 4) = 11
      numberN = numberN / 10; // numberN = 450 / 10 = 45; = 45 / 10 = 4; = 4 / 4 = 0. 
    }
   return result;
  }

Console.WriteLine($"Сумма цифр в числе {numberN} -> {GetSum(numberN)}");

