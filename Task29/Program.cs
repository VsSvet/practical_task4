using System;
using static System.Console;

Clear();
Write("Введите 8 цифр через пробел: ");
string[] Array = ReadLine().Split(" ");
WriteLine("[{0}]", string.Join(", ", Array));