/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9*/

Console.WriteLine("Введите любое целое положительное число");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите любое целое положительное число");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNumber(M, N));

static int PrintNumber(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return PrintNumber(m - 1, 1);
    }
    else
    {
        return PrintNumber(m - 1, PrintNumber(m, n - 1));
    }
}