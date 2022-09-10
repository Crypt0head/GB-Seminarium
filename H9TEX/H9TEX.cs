// Задача со звездочкой: Пользователь вводит скобочные последовательности. В последовательности могут встретиться скобки вида: {}, (), [].
// Правильная скобочная последовательность - символьная последовательность, составленная в алфавите, состоящем из символов, сгруппированных в упорядоченные пары.
// Пример правильной скобочной последовательности: (), ()[]{}
// Пример неправильной: (], ({)}
// Написать программу, которая определяет правильная ли скобочная последовательность была введена

bool ValidateBracketsStr(string str)
{
    bool IRO = false;
    bool ISO = false;
    bool ICO = false;

    foreach(char i in str)
    {
        switch(i)
        {
            case '(':
                if(!IRO && !ISO && !ICO) IRO = true; else return false;
                break;
            case '[':
                if(!IRO && !ISO && !ICO) ISO = true; else return false;
                break;
            case '{':
                if(!IRO && !ISO && !ICO) ICO = true; else return false;
                break;
            case ')':
                if(IRO && !ISO && !ICO) IRO = false; else return false;
                break;
            case ']':
                if(!IRO && ISO && !ICO) ISO = false; else return false;
                break;
            case '}':
                if(!IRO && !ISO && ICO) ICO = false; else return false;
                break;
            default:
                return false;
        }
    }

    return true;
}

Console.WriteLine("Enter brackets ");
if(ValidateBracketsStr(Console.ReadLine()))
{   Console.WriteLine("TRUE");
}
else
{
    Console.WriteLine("FALSE");
}