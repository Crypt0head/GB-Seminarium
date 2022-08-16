// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int Maxof3(int value1, int value2, int value3){
    int result = value1;

    if(value2>result){
        result=value2;
    }
    if(value3>result){
        result=value3;
    }

    return result;
}

Console.Write("Enter the first value: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter the second value: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Enter the third value: ");
int c = int.Parse(Console.ReadLine());

Console.WriteLine("Result: max is {0}", Maxof3(a,b,c)); 