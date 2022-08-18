// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// ОГРАНИЧЕНИЯ: нельзя использовать массивы и строки для решения задачи, исключительно работа с циклами и арифметическими опреациями!!!

// 14212 -> нет

// 12821 -> да

// 23432 -> да

using System;

int GetBitDepth(int val)
{
    int rem = val;
    int count = 0;

    do
    {
        count++;
        rem/=10;
    }
    while(rem!=0);

    return count;
}

bool IsPalindrom(int val)
{
    int x = val;
    int i = GetBitDepth(val);
    int begin = 0;
    int end = 0;

    while(i>1)
    {
        begin = x/Convert.ToInt32(Math.Exp((i-1)*(Math.Log(10))));
        end = x%10;
        if(begin != end)
        {
            return false;
        }
        x /= 10;
        i-=2;
        x %= Convert.ToInt32(Math.Exp((i)*(Math.Log(10))));
    }

    return true;
}

Console.WriteLine(IsPalindrom(int.Parse(Console.ReadLine())));
