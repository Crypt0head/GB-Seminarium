// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

using System;

double SolveDistance(Tuple<int,int,int> first, Tuple<int,int,int> second)
{
    return Math.Sqrt((second.Item1-first.Item1)*(second.Item1-first.Item1) + (second.Item2-first.Item2)*(second.Item2-first.Item2) + (second.Item3-first.Item3)*(second.Item3-first.Item3)); 
}

int x, y, z;

Console.WriteLine("Input first point coordiates: ");
Console.Write("X1= "); 
x = int.Parse(Console.ReadLine());
Console.Write("Y1= "); 
y = int.Parse(Console.ReadLine());
Console.Write("Z1= "); 
z = int.Parse(Console.ReadLine());
Tuple<int, int, int> A = new Tuple<int, int, int>(x,y,z);


Console.WriteLine("Input second point coordiates: ");
Console.Write("X2= "); 
x = int.Parse(Console.ReadLine());
Console.Write("Y2= "); 
y = int.Parse(Console.ReadLine());
Console.Write("Z2= "); 
z = int.Parse(Console.ReadLine());
Tuple<int, int, int> B = new Tuple<int, int, int>(x,y,z);


Console.WriteLine("Distance: {0:0.00}", SolveDistance(A, B));