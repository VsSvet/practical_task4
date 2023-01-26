using System;
using static System.Console;

Clear();
Write("Введите число A: ");
int A = int.Parse(ReadLine());
Write("Введите число B: ");
int B = int.Parse(ReadLine());
double exponentiation = GetNumberExponentiation(A, B);
WriteLine($" {A} в степени {B} = {exponentiation}");




double GetNumberExponentiation(int number, int degree)
{
    double exp = Math.Pow(number, degree);
    return exp;
}