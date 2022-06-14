// Задача 64: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("введите число больше 0: ");
int a = int.Parse(Console.ReadLine());
void AllSmallerN(int N)
{
    Console.Write($"{N} ");
    if (N-1>0)
    {
        AllSmallerN( N-1);
    }
}
AllSmallerN(a);