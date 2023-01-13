// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.WriteLine("Введите два числа для сравнения.");

Console.Write("Первое число: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());

Console.Write("Второе число: ");
int numberSecond = Convert.ToInt32(Console.ReadLine());

if (numberFirst == numberSecond)
    Console.WriteLine($"Числа равны.");

else if (numberFirst > numberSecond)
{
    Console.WriteLine($"Число {numberFirst} больше числа {numberSecond}. Max = {numberFirst}");
}
else
{
    Console.WriteLine($"Число {numberFirst} меньше числа {numberSecond}. Max = {numberSecond}.");
}