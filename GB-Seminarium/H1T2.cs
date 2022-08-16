int Comp(int value1, int value2){

    if(value1>value2){
        return value1;
    }
    else if(value1<value2){
        return value2;
    }
    else{
        return value1;
    }
}

Console.Write("Enter the first value: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter the second value: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Result: a = {0:d}; b = {1:d} -> max = {2:d}", a, b, Comp(a,b));