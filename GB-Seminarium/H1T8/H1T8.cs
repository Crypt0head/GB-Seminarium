bool IsEven(int value){
    
    if(value % 2 == 0){
        return true;
    }
    else{
        return false;
    }
}

void ShowEven(int value){
    int i = 2;
    while(true){
        if(i<=value){
            if(IsEven(i)){
                Console.Write("{0:d} ", i);
            }
            ++i;
        }
        else{
            Console.WriteLine();
            break;
        }
    }
}

Console.Write("Enter the value: ");

ShowEven(int.Parse(Console.ReadLine()));