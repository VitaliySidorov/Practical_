// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.Write("Введите натуральное число (N>1) для построение ряда четных чисел от 1 до N: ");
int number = Convert.ToInt32(Console.ReadLine());

while(number<=1)
{
   Console.Write("Неверное число, попробуйте снова: ");
   number = Convert.ToInt32(Console.ReadLine());
}

// --- Вариант 1 ---

/* 
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
*/



// --- Вариант 2 ---
if (number % 2 != 0) // Избавление от нечетности, для избавления от лишней запятой после последнего члена ряда.
{
    number = number - 1;
}
for (int i = 2; i <= (number - 2); i = i + 2)
{
    Console.Write(i + ", ");
}
Console.WriteLine(number);