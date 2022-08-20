// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 

// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] GetRandomArray(int n)
{
    int[] res = new int[n];
    
    for(int i=0;i<n;i++)
    {
        res[i] = new Random().Next(100, 1000);
    }

    return res;
}

void ShowEvenNumbers(int[] arr)
{
    foreach(int i in arr)
    {
        if(i%2 == 0)
        {
            Console.Write("{0} ", i);
        }
    }

    Console.WriteLine();
}

Console.Write("Input array size: ");
ShowEvenNumbers(GetRandomArray(int.Parse(Console.ReadLine())));