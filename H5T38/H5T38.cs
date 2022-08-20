// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] SetDoubleArray(int n)
{
    double[] res = new double[n];
    
    for(int i=0;i<n;i++)
    {
        Console.Write($"Input [{i}] element: ");
        res[i] = double.Parse(Console.ReadLine());
    }

    return res;
}

Tuple<double, double> GetMaxMin(double[] arr)
{
    double max = arr[0];
    double min = arr[0];

    foreach(double i in arr)
    {
        if(i>max)
        {
            max = i;
        }
        else if(i<min)
        {
            min = i;
        }
    }

    return new Tuple<double, double>(max, min);
}

Console.Write("Input array size: ");
Tuple<double, double> maxmin = GetMaxMin(SetDoubleArray(int.Parse(Console.ReadLine())));
Console.WriteLine("Max - Min: {0}", maxmin.Item1 - maxmin.Item2);