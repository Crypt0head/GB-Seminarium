// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] GetRandomArray(int n)
{
    int[] res = new int[n];
    
    for(int i=0;i<n;i++)
    {
        res[i] = new Random().Next(-100, 101);
    }

    return res;
}

int GetSumOfOddElements(int[] arr)
{
    int res=0;

    for(int i=1;i<arr.Length;i+=2)
    {
        res+=arr[i];
    }

    return res;
}

Console.Write("Input array size: ");
int[] arr = GetRandomArray(int.Parse(Console.ReadLine()));
Console.WriteLine("Array: {0} \nSum: {1}", String.Join(", ", arr), GetSumOfOddElements(arr));