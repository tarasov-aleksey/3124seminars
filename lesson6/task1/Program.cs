// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

while (true)
{
string s;
Console.Write("Введите элементы(через пробел):  ");
s = Console.ReadLine();
if (s == "stop") break;
int[] arr = Array.ConvertAll(s.Split(), int.Parse);
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Кол-во элементов > 0: {count}");
}