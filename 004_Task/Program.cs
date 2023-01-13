// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.Write("Введите натуральное число (N>1) для построение ряда четных чисел от 1 до N: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 2;

if (number % 2 != 0) // Избавление от нечетности, для избавления от лишней запятой после последнего члена ряда.
{
    number = number - 1;
}
if(number == i) // Проверка для вывода ряда из одной двойки.
{
    Console.WriteLine(i);
    return;
}
while (i < number)
{
    Console.Write(i + ", ");
    i = i + 2;
    if (i == number)
    {
        Console.WriteLine(i);
    }
}
