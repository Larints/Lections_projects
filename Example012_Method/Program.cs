﻿// Вид 1

void Method1()
{
    Console.WriteLine("Автор");
}
Method1();


// Вид 2

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg)
        i++;

    }
}
Method21(msg: "Текст", count: 4);

// Вид 3

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
System.Console.WriteLine(year);

// Вид 4

string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
}

string res = Method4(10, "qwerty");

System.Console.WriteLine(res);

//C использованием цикла for

string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
}

string res = Method4(10, "qwerty");

System.Console.WriteLine(res);


for (int i = 2 i <= 10; i++)
{
    for (int j = 2; j <=10; j++)
    {
        System.Console.WriteLine($"{i} x {j} = {i x j}");
    }
    System.Console.WriteLine();
}
