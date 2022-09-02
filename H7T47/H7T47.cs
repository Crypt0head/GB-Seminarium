// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

void ShowRandomDoubleArray(int n, int m)
{
    double[,] arr = new double[n,m];

    for(int i=0;i<n; i++)
    {
        for(int j=0;j<m;j++)
        {
            arr[i,j] = new Random().NextDouble() + Convert.ToDouble(new Random().Next(-10,11));
            Console.Write("{0:0.00}, ", arr[i,j]);
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Input array size NxM: ");

ShowRandomDoubleArray(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));