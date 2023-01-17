// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

Console.Write("Введите число: ");
string numberStr = Console.ReadLine();
int length = numberStr.Length;

if (length >= 3)
{
	Console.WriteLine(numberStr[2]);
}

else
{
	Console.WriteLine("Третьей цифры нет.");
}