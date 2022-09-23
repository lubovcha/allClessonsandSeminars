string[,] table = new string [2,5]; //таблица строк, две строчки, 5 столбцов
// индекс стоблика table[0,0] - 1 столбик; table[0,1] - 2 столбик; table[0,2] - 3 столбик; table[0,3] - 4 столбик
// индекс строки table[1,0] table[1,1] table[1,2] table[1,3]
// String.Empty - константа, через которую происходит инициализация
/*
table[1,2]="слово";// указываем наименование массива, что бы обращаться у нужному элементу 1 - индекс строки, 2 индекс столбца

for (int rows = 0; rows < 2; rows++) // счетчик строк rows  
{
    for (int columns = 0; columns < 5; columns++) //внутренний цикл, кол-во столбцов
    {
        Console.WriteLine($"-{table[rows, columns]}-"); // обращение к элементам массива через имя массива - строку и столбец
    }
}

*/

void PrintArray(int[,] matr) //массив с нулями
{

for (int i = 0; i < matr.GetLength(0); i++) 
{
    for (int j = 0; j < matr.GetLength(1); j++) 
    {
        Console.Write($"{matr[i, j]} ");
}
Console.WriteLine(); //переход на новую строку, что бы вывод был по строкам и столбцам, а не в стоблик 
}
}

void FillArray(int[,] matr) //массив со случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++) 
    {
        matr[i,j] = new Random().Next(1,10); // [1;10]
    }
}
}

int[,] matrix = new int[3, 4];
PrintArray(matrix); //нолики
FillArray(matrix); //заполняем
Console.WriteLine(); //прослойка между нулями и заполненным массивом
PrintArray(matrix); //результат заполненного массива случайными числами