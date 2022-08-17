// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Реализовать функцию возведения в степень самостоятельно!

int RaiseTo(int val, int pow)
{
    if(pow == 0)
    {
        return 1;
    }

    int res = val;

    for(int i=1;i<pow;i++)
    {
        res *= val;
    }

    return res;
}

Console.WriteLine("{0}", RaiseTo(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));