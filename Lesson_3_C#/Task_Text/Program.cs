/* Работа с текстом
Задача: в тексте заменить
Пробелы на черточки
Маленькие буквы "к" на "К"
Большие "С" нк маленькие "с"
*/

string text = "- Я думаю, - сказал князь, улыбаясь, - что, СС "
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли его приступом согласие прусского короля. "
+ "Вы так красноречивы. Вы дадите мне чаю?";

/* string s = "qwerty'
               012345
 s[3] = r
*/
string Replace(string text, char oldValue, char newValue) // заменить
{
    string result = String.Empty; // инициализация пустой строки

int length = text.Length;
for(int i=0; i < length; i++)
{
if(text[i] == oldValue) result = result + $"{newValue}";
else result = result + $"{text[i]}";
}
    return result;

}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'K');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);