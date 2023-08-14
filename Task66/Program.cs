// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int SumNaturalNumbers (int m, int n)
{
    int result = 0;
    for (int i = m; i<=n; i++) result +=i;
    return result;
}
Console.WriteLine($"M = 10; N = 20; Sum = {SumNaturalNumbers(10,20)}");

