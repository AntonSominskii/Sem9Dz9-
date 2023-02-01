/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.WriteLine("Введите любое целое число");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите любое целое число");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNumber(M, N));

int PrintNumber(int m, int n)
{
    if (m > n)
    {
        return 0;
    }
    else
    {
        return m + PrintNumber(m + 1, n);
    }
}
