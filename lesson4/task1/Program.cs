// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите переменную A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите переменную B: ");
int b = Convert.ToInt32(Console.ReadLine());
int a2 = a;
while (b > 1)
{
b = b - 1;
a = a * a2;
}
Console.WriteLine(a);