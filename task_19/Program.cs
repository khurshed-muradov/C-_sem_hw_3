// Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

using System.Globalization;
using System.Net;

System.Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
if (number >= 10000 && number <= 99999)
{

}
else
{
    System.Console.WriteLine("Число не пятизначное! Повторите попытку!");
}

int digit5 = number % 10;
int digit4 = (number % 100) / 10;
int digit3 = (number % 1000) / 100;
int digit2 = (number % 10000) / 1000;
int digit1 = (number % 100000) / 10000;

if (digit1 == digit5 || digit2 == digit3)
{
    System.Console.WriteLine(number + " -> " + "Да");
}
else
{
    System.Console.WriteLine("Нет");
}
