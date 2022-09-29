// Массив из случайных чисел, 12 элементов из промежутка [-9,9]. Найти сумму отрицательных и положительных элементов массива. 

int[] GenerateArray(int length) { //универсальный код, функция возвращает массив
var array = new int[length];

var random = new Random(); //var = замещает любой тип данных - int и т.д. 

for (var i = 0; i < array.Length; i++) { //цикл, что бы пройти по всем элементам массива 
array [i] = random.Next(-9,10); // указывам 10, т.к. если ставим 9, то 9 не выйдет
}
return array;
}

void PrintArray(int[] array){ //принимает массив, ничего не возвращает
for (var i = 0; i < array.Length; i++) { //цикл, что бы пройти по всем элементам массива 
Console.Write(array[i] + ", "); 
}
Console.WriteLine(array[array.Length - 1]); // что бы не ставилась запятая после последней цифры массива
}

int SumPositiveNumbers(int[] array) {
    var result = 0;

for (var i = 0; i < array.Length; i++) { 
if (array[i] > 0)      
result += array[i];  
}
return result; 
}

int SumNegativeNumbers(int[] array) {
 var result = 0;
for (var i = 0; i < array.Length; i++) { 
if (array[i] < 0)
result += array[i]; 
}  
return result; 
}
var array = GenerateArray(12);
PrintArray(array);

var positiveSum = SumPositiveNumbers(array);
Console.WriteLine(positiveSum);

Console.WriteLine(SumNegativeNumbers(array));

