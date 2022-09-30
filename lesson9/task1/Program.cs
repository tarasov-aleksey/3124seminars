﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int a = InputNumbers("Введите положительное число: ");
int count = 2;
PrintNumber(a, count);
Console.Write(1);
if (a < 1)
{
 Console.WriteLine($"\nВвели не положительное число: {a}");
}

void PrintNumber(int a, int count)
{
  if (count > a) return;
  PrintNumber(a, count + 1);
  Console.Write(count + ", ");
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
Console.WriteLine();
