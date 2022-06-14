// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int recursion(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    // условие рекурсии
    else if (n == 0 && m > 0)
    {
        return recursion(m - 1, 1);
    }
    // условие рекурсии
    else
    {
        return recursion(m - 1, recursion(m, n - 1));
    }
}
Console.Write("введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("введите число n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(recursion(m, n));