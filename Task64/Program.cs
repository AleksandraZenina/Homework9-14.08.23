// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

string NaturalNumbers (int n, int m)
{
    if (n>=1) return $"{n} " + NaturalNumbers(n-1,1);
    else return string.Empty;
}
Console.WriteLine (NaturalNumbers(12,1));