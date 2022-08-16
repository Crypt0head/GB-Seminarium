// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

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