﻿// Задача 23: Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9.
// 5 -> 1, 8, 27, 64, 125
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Number()
{
    System.Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
int number = Number();
System.Console.Write(number + " -> ");
for (int i = 1; i <= number; i++)
{
    if (i == number)
    {
        System.Console.Write((i * i) * i);
    }
    else
    {
        System.Console.Write(((i * i) * i) + ", ");
    }
}
