// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Enter two numbers as first and last range values: ");
double m = Double.Parse(Console.ReadLine());
double n = Double.Parse(Console.ReadLine());

double res = 0;

for(double i = Math.Round(m+0.4, MidpointRounding.AwayFromZero);i<=Math.Round(n, MidpointRounding.ToZero);i++)
{
    res+=i;
}

Console.WriteLine("Output: {0}", res);