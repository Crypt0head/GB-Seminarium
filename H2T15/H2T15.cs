// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

void IsWeekend(int val){
    if(val > 5 && val < 8){
        Console.WriteLine("Yes");
    }
    else{
        Console.WriteLine("No");
    }
}

Console.Write("Input digit: ");
IsWeekend(int.Parse(Console.ReadLine()));