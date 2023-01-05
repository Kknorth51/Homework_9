//  Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
//  натуральных элементов в промежутке от M до N.
//  M = 1; N = 15 -> 120
//  M = 4; N = 8. -> 30 

Console.Write("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N большее чем M: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"{SumR(M,N)}");

int SumR(int M, int N)
{
    if (M == N) return M;
    return N + (SumR(M,N-1)); 
}