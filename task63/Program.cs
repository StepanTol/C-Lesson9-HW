//Задача 63: Задайте значение N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от 1 до N.
//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"


string NaturalN(int start, int end)
{
    if (start == end)
    {
        return start.ToString(); 
    }
    return(start+" "+NaturalN(start+1,end));
}
Console.WriteLine(NaturalN(1,5));