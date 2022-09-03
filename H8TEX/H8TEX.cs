// Задача со звездочкой:
// Написать функцию Sqrt(x) - квадратного корня, которая принимает на вход целочисленное 
// значение x и возвращает целую часть квадратного корня от введенного числа.

// 4 -> 2
// 28 -> 5

// Нельзя использовать встроенные функции библиотеки Math!

int sqrt(int val)
{
    double x = val/2, a;
    int res = 0;
    while(res!=System.Convert.ToInt32(x-x%1))
    {
        res=System.Convert.ToInt32(x-x%1);
        a=(val-x*x)/(2*x);
        x = (x+a)-(a*a)/(2*(x+a));
    }
    return res;
}

Console.Write("Enter number: ");
Console.WriteLine("Output: {0}", sqrt(int.Parse(Console.ReadLine())));
