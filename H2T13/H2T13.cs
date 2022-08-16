// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Строки и циклы в решении использовать нельзя!)

// 645 -> 6

// 78 -> третьей цифры нет

// 32679 -> 6

void ShowThirdDigit(int value)
{
    int res = value/100%10;

    if(res == 0 && value/1000 == 0){
        Console.WriteLine("Output: There is no third digit in given number");
    }
    else{
        Console.WriteLine("Output: {0}", res);
    }

}

Console.Write("Input three-digit number: ");
ShowThirdDigit(int.Parse(Console.ReadLine()));