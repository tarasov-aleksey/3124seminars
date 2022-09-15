//  Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int amount = number.ToString().Length;
if (amount<3)
{
    Console.WriteLine("Третьей цифры нет");
}
else 
{
    for (int i = amount; i > 3; i--)
    Console.WriteLine ((number / 10) % 10);
}