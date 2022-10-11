// Вид 1. Ничего не принимают и ничего не возвращают
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();

// Вид 2. Что-то принимают, но ничего не возвращают.
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
        i++; // инкримент
    }
}
Method21(msg: "Текст", count: 4); // аргументы можно менять местами (count: 4, msg: "Текст")


// Вид 3. Что-то возвращают, но ничего не принимают. 

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Вид 4. Что-то принимают и что-то возвращают.

string Method4(int count, string text)
{
    string result = String.Empty; //присваивание пустой строки

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "asdf");
Console.WriteLine(res);


for (int i = 2; i <= 10; i++) // таблица умножения
{
    for (int j = 2; j <=10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}
