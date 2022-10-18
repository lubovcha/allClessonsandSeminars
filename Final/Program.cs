int Initial(string message) //получаем данные массива
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

string[] FillArray(string[] array) //формируем массив
{
    string[] filledArray = array;
    for (int i = 0; i < filledArray.Length; i++)
    {
        filledArray[i] = Convert.ToString(Console.ReadLine());
    }
    return filledArray;
}

int FindSizeArray(String[] array) //проверяем введенный массив
{
    int sizeElement = 3;
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= sizeElement)
        {
            count++;
        }
    }
    return count;
}

string[] GetSortArray(string[] array, int sizeSortArray) //присваеваем индексы
{
    string[] sortedArray = new string[sizeSortArray];
    int sizeElement = 3;
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= sizeElement)
        {
            sortedArray[j] = array[i];
            j++;
        }
    }
    return sortedArray;
}

void PrintArray(string[] array) // добавляем []
{
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write($"{array[array.Length-1]}]");
    Console.WriteLine();
}

int size = Initial("Задайте размер первоначального массива, введя цифру: ");
string[] array = new string[size];
System.Console.WriteLine($"Внесите данные массива, вводя {size} значений, каждое с новой строчки: ");
string[] filledArray = FillArray(array);
System.Console.WriteLine();
System.Console.WriteLine("Ваш массив:");
PrintArray(filledArray);
int sizeSortedArray = FindSizeArray(filledArray);
string[] sortedArray = GetSortArray(filledArray, sizeSortedArray);
System.Console.WriteLine();
System.Console.WriteLine("Итоговый массив:");
PrintArray(sortedArray);