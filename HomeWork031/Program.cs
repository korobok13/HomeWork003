// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
var num = Convert.ToInt32(Console.ReadLine());

int a1 = num / 10000;
int a2 = num % 10;
int b3 = (num / 1000) % 10;
int b4 = (num % 100) / 10;

if (a1 == a2 && b3 == b4)
{
    Console.WriteLine(num+ " -> Да, это палиндром!");
}
else
{
    Console.WriteLine(num+ " -> Нет");
}