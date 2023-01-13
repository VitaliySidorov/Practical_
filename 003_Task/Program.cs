﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.WriteLine("Введите число для определения его четности или нечетности.");

Console.Write(":> ");
int number = Convert.ToInt32(Console.ReadLine());

if(number%2 == 0)
{
    Console.WriteLine($"Число {number} кратно 2, следовательно является четным.");
}
else
{
    Console.WriteLine($"Число {number} не делится нацело на 2, следовательно оно нечетное.");
}
