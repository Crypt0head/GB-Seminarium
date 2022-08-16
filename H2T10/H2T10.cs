int GetSecondDigit(int value)
{
    return value/10%10;
}

Console.Write("Input three-digit number: ");
Console.WriteLine("Output: {0}", GetSecondDigit(int.Parse(Console.ReadLine())));