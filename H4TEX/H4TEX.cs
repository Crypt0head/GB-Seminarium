// Задача “со звездочкой”: (необязательное) 
// Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.

const int PROG_STEP = 2;
const int PROG_FIRST = 1;

String FillWithSym(String str, int times)
{
    String res = "";

    for(int i=0;i<times;i++)
    {
        res+=str;
    }

    return res;
}

void PrintTree(int hight)
{
    for(int i=0;i<hight;i++)
    {
        Console.Write(FillWithSym(" ", hight-i-1) + FillWithSym("*", PROG_FIRST+i*PROG_STEP) + "\n");
    }
}

Console.Write("Input tree hight: ");
PrintTree(int.Parse(Console.ReadLine()));