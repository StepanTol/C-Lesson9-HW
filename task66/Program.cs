//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.Write("Введите значение M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine()!);

int Getsum(int a, int b)
{
    if (a == b)
    {
        return b; 
    }
    return(b + Getsum(a, b - 1));
}
Console.WriteLine(Getsum(M,N));