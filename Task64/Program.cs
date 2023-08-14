// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

string NaturalNumbers (int n)
{
    string result = string.Empty;
    if (n>=1)
    for (int i=n; i>=1; i--)
    {
        result += $"{i} ";
    }
    return result;
}
Console.WriteLine (NaturalNumbers(10));