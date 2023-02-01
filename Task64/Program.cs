/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"8*/

Console.WriteLine("Введите любое целое число");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNumber(N));

string PrintNumber(int n)
{
    if (n == 1)
    {
        return "1";
    }
    else
    {
        return n + ", " + PrintNumber(n - 1);
    }
}