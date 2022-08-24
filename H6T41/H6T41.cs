// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int[] SetArray(int m)
{
    int[] res = new int[m];
    
    for(int i=0;i<res.Length;i++)
    {
        Console.Write("Input [{0}] element: ", i+1);
        res[i] = int.Parse(Console.ReadLine());
    }

    return res;
}

int GetCount(int[] arr)
{
    int res = 0;

    foreach(int i in arr)
    {
        if(i > 0)
        {
            res++;
        }
    }

    return res;
}

Console.Write("Input array size: ");
Console.Write("Output: {0} \n", GetCount(SetArray(int.Parse(Console.ReadLine()))));