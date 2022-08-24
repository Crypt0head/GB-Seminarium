// Задача со звездочкой: Напишите программу, которая реализует обход введенного двумерного массива, 

// начиная с крайнего нижнего левого элемента против часовой стрелки.

// 1 2 3
// 4 5 6 -> 7 8 9 6 3 2 1 4 5
// 7 8 9

class Program
{
    enum Mode
    {
        LEFTRIGHT,
        DOWNUP,
        RIGHTLEFT,
        UPDOWN
    }

    static int[,] Set2DArray(int n, int m)
    {
        int[,] res = new int[n, m];
        
        for(int i=0;i<res.GetLength(0);i++)
        {
            for(int j=0;j<res.GetLength(1);j++)
            {
                Console.Write($"Input [{i}, {j}] element: ");
                res[i, j] = int.Parse(Console.ReadLine());
            }
        }

        return res;
    }

    static void Print2DArray(int[,] arr)
    {   
        for(int i=0;i<arr.GetLength(0);i++)
        {
            for(int j=0;j<arr.GetLength(1);j++)
            {
                Console.Write($"{arr[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    static void PrintReversClockOrder(int[,] arr)
    {
        int i = arr.GetLength(0)-1;
        int j = 0;
        int count = 0;
        int offset = 0;
        Mode m = Mode.LEFTRIGHT;
        
        while(count<arr.Length)
        {
            Console.Write($"{arr[i, j]} ");

            switch(m)
            {
                case Mode.LEFTRIGHT:
                    if(j<arr.GetLength(1)-1-offset)
                    {
                        j++;
                    }
                    else
                    {
                        i--;
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
                        i++;
                        offset++;
                        m = Mode.UPDOWN;
                    }
                    break;

                case Mode.UPDOWN:
                    if(i<arr.GetLength(0)-1-offset)
                    {
                        i++;
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
        Console.Write("\n");

    }

    static void Main()
    {

        Console.Write("Input 2d array size [NxM]: ");
        int[,] arr = Set2DArray(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));

        Console.WriteLine("\nArray:");
        Print2DArray(arr);

        Console.WriteLine("\nOutput:");
        PrintReversClockOrder(arr);
    }
}