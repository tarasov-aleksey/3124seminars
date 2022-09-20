// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int num, rem, sum = 0, temp;
Console.WriteLine("Введите число ");
num = Convert.ToInt32(Console.ReadLine());
temp = num;
while (Convert.ToBoolean(num))
{
    rem = num % 10;
    num = num / 10;
    sum = sum * 10 + rem;
}
if (temp == sum)
{
    Console.WriteLine("Палиндром");
}
else
{
    Console.WriteLine("Не палиндром");
}