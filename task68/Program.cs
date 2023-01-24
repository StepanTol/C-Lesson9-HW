//адача 68: Напишите программу вычисления функции Аккермана с помощью 
//рекурсии. Даны два неотрицательных числа m и n. 
//m = 2, n = 3 -> A(m,n) = 29

Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение M: ");
int M = int.Parse(Console.ReadLine()!);

int Akerman (int n, int m)
{
    if (n == 0)
    {
        return m+1;
    }
    else
    {
        if (n != 0 && m == 0)
        {
            return Akerman(n-1, 1);
        }
        else 
        {
            return Akerman(n-1, Akerman(n, m-1));
        }
    }
}
Console.WriteLine(Akerman(N,M));