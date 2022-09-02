// Задача со звездочкой. Написать программу для перевода римских чисел в десятичные арабские.

// III -> 3
// LVIII -> 58
// MCMXCIV -> 1994

int RomanToInt(Char ch)
{
    switch(ch)
    {
        case 'I':
            return 1;
            break;
        case 'V':
            return 5;
            break;
        case 'X':
            return 10;
            break;
        case 'L':
            return 50;
            break;
        case 'C':
            return 100;
            break;
        case 'D':
            return 500;
            break;
        case 'M':
            return 1000;
            break;
        default:
            return -1;
            break;
    }
}

int ConverRomanToInt(string str)
{
    int res = 0;
    int prev = 0;
    int cur = 0;

    foreach(char ch in str)
    {
        cur = RomanToInt(ch);
        
        if(prev<cur)
        {
            res+=cur-2*prev;
        }
        else if(prev>=cur)
        {
            res+=cur;
        }

        prev = cur;
    }

    return res;
}

Console.WriteLine("Input Roman number: ");
Console.WriteLine(ConverRomanToInt(Console.ReadLine()));
