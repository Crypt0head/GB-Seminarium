// Задача 27: Напишите функцию и запустите ее, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int SumOfDigits(int val)
{
    int res = 0;
    int rem = val;

    while(rem > 0)
    {
        res += rem % 10;
        rem /= 10; 
    }

    return res;
}

Console.WriteLine("{0}", SumOfDigits(int.Parse(Console.ReadLine())));