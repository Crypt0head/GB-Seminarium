void IsEven(int value){
    
    if(value % 2 == 0){
        Console.WriteLine("yes");
    }
    else{
        Console.WriteLine("no");
    }
}

Console.Write("Enter the value: ");

IsEven(int.Parse(Console.ReadLine()));