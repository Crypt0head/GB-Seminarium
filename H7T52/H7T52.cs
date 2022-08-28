// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] MakeRandomArray(int n, int m)
{
    int[,] arr = new int[n,m];

    for(int i=0;i<n; i++)
    {
        for(int j=0;j<m;j++)
        {
            arr[i,j] = new Random().Next(-10, 11);
            Console.Write("{0}, ", arr[i,j]);
        }
        Console.WriteLine();
    }

    return arr;
}

void ShowAvrOfRows(int[,] arr)
{
    int rows = arr.GetUpperBound(0) + 1;
    int columns = arr.Length / rows;

    for(int i=0;i<rows;i++)
    {
        double res = 0;
        for(int j=0;j<columns;j++)
        {
            res+=arr[i,j];
        }
        res/=columns;
        Console.Write("{0}, ", res);
    }
}


Console.WriteLine("Input array size NxM: ");

ShowAvrOfRows(MakeRandomArray(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
