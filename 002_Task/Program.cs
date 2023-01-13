// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.WriteLine("Введите три числа для нахождения максимального из них.");

Console.Write("Первое число: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());

Console.Write("Второе число: ");
int numberSecond = Convert.ToInt32(Console.ReadLine());

Console.Write("Третье число: ");
int numberThird = Convert.ToInt32(Console.ReadLine());

int Max = numberFirst;

if (numberSecond > Max)
{
    Max = numberSecond;
}
if (numberThird > Max)
{
    Max = numberThird;
}

Console.WriteLine($"Максимальное число -> {Max}");