// Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.
// [3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
// [1,2,2,3,2] -> [3, 2, 2, 2, 1]

int[] SetIntArray(int n)
{
    int[] res = new int[n];
    
    for(int i=0;i<n;i++)
    {
        Console.Write($"Input [{i}] element: ");
        res[i] = int.Parse(Console.ReadLine());
    }

    return res;
}

int[] BubbleSort(int[] arr)
{
    for(int i=0;i<arr.Length-1;i++)
    {
        for(int j=0;j<arr.Length-1;j++)
        {
            if(arr[j+1]>arr[j])
            {
                int tmp = arr[j];
                arr[j] = arr[j+1];
                arr[j+1] = tmp;
            }
        }
    }

    return arr;
}

Console.Write("Input array size: ");
Console.WriteLine("{0} ", String.Join(", ", BubbleSort(SetIntArray(int.Parse(Console.ReadLine())))));