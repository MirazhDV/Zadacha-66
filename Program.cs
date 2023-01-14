// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSummNumbers(int m, int n)
{
    if (m==n-1)
    {
        return m+n;      
    }
    else
    {
        return m + GetSummNumbers(m+1, n);        
    }   
}
Console.WriteLine(GetSummNumbers(1,15));