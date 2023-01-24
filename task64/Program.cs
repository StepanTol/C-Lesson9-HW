/*Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "4,2"
N = 8 -> "8, 6, 4, 2"*/


string ParityN(int a, int b)
{
    if (a == b)
    {
        if (a%2 == 0)
        {
            return a.ToString();
        }
    }
    return (a +" "+ParityN(a+1, b));    
}
Console.WriteLine(ParityN(3,12));