// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] MakeRandomArray(int n, int m)
{
    int[,] arr = new int[n,m];

    for(int i=0;i<n; i++)
    {
        for(int j=0;j<m;j++)
        {
            arr[i,j] = new Random().Next(0, 10);
            Console.Write("{0}, ", arr[i,j]);
        }
        Console.WriteLine();
    }

    return arr;
}

int FindRowWithMinSum(int[,] arr)
{
    int rows = arr.GetUpperBound(0) + 1;
    int columns = arr.Length / rows;

    int res = 0;
    int min_sum = int.MaxValue;
    int cur_sum = 0;

    for(int i=0;i<rows;i++)
    {
        cur_sum = 0;
        for(int j=0;j<columns;j++)
        {
            cur_sum+=arr[i,j];
        }
        
        if(cur_sum<min_sum)
        {
            res = i;
            min_sum=cur_sum;
        } 

        Console.WriteLine("Sum of {0} row: {1}", i+1, cur_sum);
    }

    return res;
}

Console.WriteLine("Input 2d array dimensions NxM: ");
int[,] arr = MakeRandomArray(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));
Console.WriteLine();
Console.WriteLine("\nOutput: {0} row", FindRowWithMinSum(arr)+1);