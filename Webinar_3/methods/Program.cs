// Вид 1 (ничего не возвращают и ничего не принимают)
void Method1()
{
    Console.WriteLine("Автор: Михаил Быков");
}
Method1(); // не забываем указывать скобки при вызове метода, иначе не будет работать




// Вид 2 (ничего не возвращает но может принимать какие-то аргументы)
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i< count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("текст", 4);
Method21(count: 4, msg: "новый текст");




// Вид 3 (чтото возвращает но ничего не прингимает)
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);




// Вид 4 (что то принимают и чтото возвращают)
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while ( i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);