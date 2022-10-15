int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int [] array) 
{
    int count = 3;
    for (int i = 0; i < count; i++) 
    {
System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

PrintArray(arr);