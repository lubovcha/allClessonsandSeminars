// Метод 1 не возвращают, не принимают 
/*
void Method1() 
{
System.Console.WriteLine("Люба");
}

Method1();  - вызывать метод, скобки обязательны 


// Метод 2 не возвращают,  принимают аргументы 

void Method2(string msg)
{
    System.Console.WriteLine(msg);
}
// Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}
Method21(msg:"новый текст", count: 4); // сколько раз будет выводиться сообщение или Method21("Текст", 4);


// Метод 3: что-то возвращают, но не принимают
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);
*/
string Method4(int count, string text)
{
int i = 0;
string result = String.Empty;

while (i < count)
{
    result = result + text;
    i++;
}
return result;
}
string res = Method4 (10, "z");
Console.WriteLine(res);