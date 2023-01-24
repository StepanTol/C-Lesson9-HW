﻿//Задайте значения M и N. Напишите программу, которая 
//выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5 -> "1, 2, 3, 4, 5"
//M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.Write("Введите значение M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine()!);

string NaturalN(int start, int end)
{
    if (start == end)
    {
        return start.ToString(); 
    }
    return(start+" "+NaturalN(start+1,end));
}
Console.WriteLine(NaturalN(M,N));