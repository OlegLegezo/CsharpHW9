// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("введите число M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("введите число N: ");
int N = int.Parse(Console.ReadLine());

void AllBetweenMN(int a, int b, int c)
{
    if (a <= b)
    {
        c = a + c;
        AllBetweenMN(a + 1, b, c);
    }
    else
    {
        Console.WriteLine(c);
    }
}


int x = 0;
if (M > N)
{
    Console.WriteLine("число M должно быть меньше числа N!");
}
else
{
    AllBetweenMN(M, N, x);
}

