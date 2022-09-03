// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] MakeRandom3DArray(int row, int col, int z)
{
    if(row*col*z>=90)
    {
        Console.WriteLine("ERROR: The array could contain only unique 2-digit numbers, which means not more than 90 members.\nPlease try another input.");
        return new int[0,0,0];
    }

    int[,,] arr = new int[row,col,z];
    List<int> list = new List<int>();
    bool unique = false;

    for(int i=0;i<row; i++)
    {
        for(int j=0;j<col;j++)
        {
            for(int k=0, tmp=0;k<z;k++)
            {
                unique = false;
                while(!unique)
                {
                    tmp = new Random().Next(10, 100);
                    if(!list.Contains(tmp))
                    {
                        arr[i,j,k] = tmp;
                        list.Add(tmp);
                        unique = true;
                    }
                       
                }
            }
        }
    }

    return arr;
}

void Print3DArray(int[,,] arr)
{
    if(arr.Length == 0)
        return;
        
    int rows = arr.GetUpperBound(0)+1;
    int columns = arr.GetUpperBound(1)+1;
    int z = arr.GetUpperBound(2)+1;

    for(int i=0;i<z; i++)
    {
        for(int j=0;j<rows;j++)
        {
            for(int k=0;k<columns;k++)
            {
                Console.Write($"{arr[j,k,i]}({j},{k},{i}) ");
            }
            Console.WriteLine();
        }
    }
}

Console.WriteLine("Enter dimansions NxMxL: ");
int[,,] arr = MakeRandom3DArray(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));
Print3DArray(arr);