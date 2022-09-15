// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int amount = number.ToString().Length;
if (amount<3 || amount>3)
{
    Console.WriteLine("Ввели не трехзначное число");
}
else
{
    Console.WriteLine((number/10)%10);
}