// Задача 29: Напишите программу, которая задаёт массив из N элементов, заполненных случайными числами из [a, b) и выводит их на экран.

// 5, 0, 20 -> [1, 2, 5, 7, 19]

// 3, 1, 35 -> [6, 1, 33]

void ShowRandomArray(int n, Tuple<int, int> range)
{
    int[] arr = new int[n];

    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(range.Item1, range.Item2);
    }

    Console.WriteLine("[{0}]", string.Join(", ", arr));
}

Console.WriteLine("Input array size: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Input range: ");

ShowRandomArray(n, new Tuple<int, int>(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));