// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] MakeRandomArray(int n, int m)
{
    int[,] arr = new int[n,m];

    for(int i=0;i<n; i++)
    {
        for(int j=0;j<m;j++)
        {
            arr[i,j] = new Random().Next(0, 100);
            Console.Write("{0}, ", arr[i,j]);
        }
        Console.WriteLine();
    }

    return arr;
}

int[,] BubbleSort2DArrRows(int[,] arr)
{
    int rows = arr.GetUpperBound(0) + 1;
    int columns = arr.Length / rows;

    for(int i=0;i<rows;i++)
    {
        for(int j=0;j<columns-1;j++)
        {
            bool bSort = true;
            for(int k=0;k<columns-j-1;k++)
            {
                if(arr[i,k+1]>arr[i,k])
                {
                    int tmp = arr[i,k];
                    arr[i,k] = arr[i,k+1];
                    arr[i,k+1] = tmp;
                    bSort = true;
                }
                if(!bSort) break;
            }
        }
    }
    return arr;
}

void Print(int[,] arr)
{
    int rows = arr.GetUpperBound(0) + 1;
    int columns = arr.Length / rows;

    Console.WriteLine();

    for(int i=0;i<rows;i++)
    {
        for(int j=0;j<columns;j++)
        {
            Console.Write("{0}, ", arr[i,j]);
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Input 2d array dimensions NxM: ");
int[,] arr = MakeRandomArray(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));
Console.WriteLine();
Print(BubbleSort2DArrRows(arr));