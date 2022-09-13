/*
Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

[1,0,1,1,0,1,0,0]

int [] arr = new int [8];
for(int i = 0; i < 8; i++){
    arr[i] = new Random().Next(0, 2);
}
void PrintArray(int[] collection){
    for(int count = 0; count < collection.Length; count++){
        System.Console.Write($"{collection[count]}, ");
    }
}
PrintArray(arr);
Console.WriteLine();
*/

//Вариант препода
int[] GetArray(){ //создаем массив
    int[] result = new int [8]; //задаем длинну
    for(int i = 0; i < result.Length; i++) //пока условия сохраняются
    {
        result[i] = new Random().Next(2); //печатается массив из цифр 0,1 (до 2)
    }
    return result;
}
void PrintArray(int[] arr){ //
    for(int i = 0; i < arr.Length; i++)
{
        System.Console.Write(arr[i]);
}
}

PrintArray(GetArray());




