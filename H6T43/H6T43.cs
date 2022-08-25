// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 

// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Tuple<double, double> SetLinearFunc()
{
    Console.Write("Input k factor: ");
    double k = double.Parse(Console.ReadLine());

    Console.Write("Input b member: ");
    double b = double.Parse(Console.ReadLine());

    Console.Write("Linear Func: y = {0} * x + {1} \n", k, b);

    return new Tuple<double, double>(k, b);
}

Tuple<double, double> FindCrossingDot(Tuple<double, double> line1, Tuple<double, double> line2)
{
    double x = (line2.Item2 - line1.Item2)/(line1.Item1-line2.Item1);
    double y = line1.Item1 * x + line1.Item2;

    return new Tuple<double, double>(x, y);
}

Console.WriteLine("Input two linear functions: ");
Tuple<double, double> dot = FindCrossingDot(SetLinearFunc(), SetLinearFunc());
Console.Write("Output: ({0}; {1})\n", dot.Item1, dot.Item2);