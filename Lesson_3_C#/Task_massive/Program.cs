/* 
Сортировка массива (найти мин и мах, выстроить массив от мин до мах)
1 Найти позицию минимального элемента
2 Обменять позицию минимального с первой позицией
3 Повторять действия по всему масссиву
*/
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int [] array) // в качестве аргумента массив
{
    int count = array.Length; // получение кол-ва элементов будут иметь разные наименования
    for (int i = 0; i < count; i++) // пробегаем по всем элементам массива
    {
System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}
void SelectionSort(int [] array) //метод, который упорядычивает массив 
{
    for (int i = 0; i < array.Length -1; i++) //пройтись по всем элементам массива, -1 для того, что бы дало общее кол-во элементов
    {
    {
        int minPosition = i; // запоминаем позицию рабочего элемента 

// // в этом блоке кода ищем максимальный элемент
    for (int j = i + 1; j < array.Length; j++) //начальная позиция поиска + следующая позиция
    if(array [j] < array[minPosition]) minPosition = j; 
    }
        int temporary = array[i]; // премеменнная позиция
        array[i] = array[minPosition]; //положить в i позицию найденный элемент, обмен двух переменных местами
        array[minPosition] = temporary; //кладем в мин позицию временный элемент

    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
