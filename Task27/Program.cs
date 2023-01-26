using System;
using static System.Console;

Clear();
Write("Введите число N: ");
int N = int.Parse(ReadLine());
int summa = GetSumNumbers(N);
WriteLine($"Сумма = {summa}");




int GetSumNumbers(int number)
{
    int sum = 0;
    for(int i = 1; i<=number; i++)
    {
        sum += number%10;
        number = number/10;
    }
    return sum;
}