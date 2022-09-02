// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

public class Matrix2D
{
    public int[,] arr;
    public int rows;
    public int columns;

    public Matrix2D(int row = 0, int col = 0)
    {
        rows = row <= 0 ? new Random().Next(1, 21) : row;
        columns = col <= 0 ? new Random().Next(1, 21) : col;

        arr = MakeRandomArray(rows, columns);
    }

    public Matrix2D(string str)
    {
        arr = new int[1,1];
        arr[0,0] = 0;
    }

    public int[,] MakeRandomArray(int row, int col)
    {
        int[,] arr = new int[row,col];

        for(int i=0;i<row; i++)
        {
            for(int j=0;j<col;j++)
            {
                arr[i,j] = new Random().Next(0, 10);
            }
        }

        return arr;
    }

    public override string ToString()
    {
        string matrix_in_string = "";

        for(int i=0;i<rows;i++)
        {
            for(int j=0;j<columns;j++)
            {
                matrix_in_string+=arr[i,j].ToString()+' ';
            }
            matrix_in_string+='\n';
        }
        return matrix_in_string;
    }

    public int this[int val1, int val2]
    {
        get => arr[val1, val2];
        set => arr[val1, val2] = value;
    }

    public static Matrix2D operator*(Matrix2D value1, Matrix2D value2)
    {
        Matrix2D res = new Matrix2D(value1.rows, value1.columns);

        if(value1.columns != value2.rows)
        {
            Console.WriteLine("Matrices are not consistent\n");
            return new Matrix2D("null");
        }

        for(int i=0;i<res.rows;i++)
        {
            for(int j=0;j<res.columns;j++)
            {
                int sum = 0;
                for(int k=0;k<res.columns;k++)
                {
                    sum+=value1[i,k]*value2[k,j];
                }
                res[i,j] = sum;
            }
        }

        return res;

    }
}

class MatrixMultiplication
{
    static void Main()
    {
        Matrix2D mtx1 = new Matrix2D(2,2);
        Console.WriteLine($"Matrix1:\n{mtx1.ToString()}");
        Matrix2D mtx2 = new Matrix2D(2,2);
        Console.WriteLine($"Matrix2:\n{mtx2.ToString()}");

        Console.WriteLine($"Matrix1*Matrix2:\n{(mtx1*mtx2).ToString()}");
    }
}