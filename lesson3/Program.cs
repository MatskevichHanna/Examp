void Method1()
{
    Console.WriteLine("Автор");
}
Method1();


void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");


void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст сообщения", 4);

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);


// int Method4(int count, string c)
// {
//     int i = 0;
//     string result = String.Empty;
//     while(i < count)
//     {
//         result = result + c;
//         i ++;
//     }
//     return result;
// }
// string rec = Method4(4, "asdf");
// Console.WriteLine(rec);

int Method4(int count, string c)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}
string rec = Method4(4, "asdf");
Console.WriteLine(rec);