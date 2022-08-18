// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
using System;

void PrintCubeTable(int val)
{
    for(int i=1;i<=val;i++)
    {
        Console.Write("{0} ", Convert.ToInt32(Math.Exp(3*Math.Log(i))));
    }

    Console.WriteLine();
}

Console.Write("Input N: ");
PrintCubeTable(int.Parse(Console.ReadLine()));