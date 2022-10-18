int Initial(string message) 
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

string[] CreateArray(string[] array) 
{
    string[] createdArray = array;
    for (int i = 0; i < createdArray.Length; i++)
    {
        createdArray[i] = Convert.ToString(Console.ReadLine());
    }
    return createdArray;
}

int FindSizeArray(String[] array) 
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

string[] NewArray(string[] array, int sizeNewArray) 
{
    string[] newArray = new string[sizeNewArray];
    int sizeElement = 3;
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= sizeElement)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

void PrintArray(string[] array) 
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
string[] createdArray = CreateArray(array);
System.Console.WriteLine("Первоначальный массив:");
PrintArray(createdArray);
int sizeNewArray = FindSizeArray(createdArray);
string[] newArray = NewArray(createdArray, sizeNewArray);
System.Console.WriteLine("Итоговый массив:");
PrintArray(newArray);

