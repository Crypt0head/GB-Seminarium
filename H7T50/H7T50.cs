// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// m = 1, n =7 -> такого числа в массиве нет

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

void GetByIndex(int n, int m, int[,] arr)
{
    int rows = arr.GetUpperBound(0) + 1;
    int columns = arr.Length / rows;

    if((n<rows) && (m<columns))
    {
        Console.WriteLine("Element [{0},{1}]: {2}", n, m, arr[n,m]);
    }
    else
    {
        Console.WriteLine("There is no such element in this array.");
    }


}


Console.WriteLine("Input array size NxM: ");

int[,] arr = MakeRandomArray(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));


Console.WriteLine("Input index [N,M] to search: ");

GetByIndex(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), arr);
