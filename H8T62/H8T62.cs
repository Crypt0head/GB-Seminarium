// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

class Program
{
    enum Mode
    {
        LEFTRIGHT,
        UPDOWN,
        RIGHTLEFT,
        DOWNUP,
    }

    static void FillSpiralArray(int[,] arr)
    {
        int row = arr.GetUpperBound(0)+1;
        int col = arr.GetUpperBound(1)+1;
        int i = 0;
        int j = 0;
        int count = 1;
        int offset = 0;
        Mode m = Mode.LEFTRIGHT;
        
        while(count<arr.Length+1)
        {
            arr[i, j] = count;

            switch(m)
            {
                case Mode.LEFTRIGHT:
                    if(j<col-1-offset)
                    {
                        j++;
                    }
                    else
                    {
                        i++;
                        m = Mode.UPDOWN;
                    }
                    break;

                case Mode.UPDOWN:
                    if(i<row-1-offset)
                    {
                        i++;
                    }
                    else
                    {
                        j--;
                        m = Mode.RIGHTLEFT;
                    }
                    break;

                case Mode.RIGHTLEFT:
                    if(j>0+offset)
                    {
                        j--;
                    }
                    else
                    {
                        i--;
                        offset++;
                        m = Mode.DOWNUP;
                    }
                    break;

                case Mode.DOWNUP:
                    if(i>0+offset)
                    {
                        i--;
                    }
                    else
                    {
                        j++;
                        m = Mode.LEFTRIGHT;
                    }
                    break;
            }

            count++;

        }
    }

    static void Print(int[,] arr)
    {
        int row = arr.GetUpperBound(0)+1;
        int col = arr.GetUpperBound(1)+1;

        for(int i=0;i<row;i++)
        {
            for(int j=0;j<col;j++)
            {
                Console.Write($"{arr[i,j]:00} ");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter array dimensions NxM: ");
        int[,] arr = new int[int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine())];
        Console.WriteLine("Output:");
        FillSpiralArray(arr);
        Print(arr);
    }
}