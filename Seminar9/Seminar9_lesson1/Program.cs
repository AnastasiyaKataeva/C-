// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

Console.Write("Задайте значение M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

void evenNumbers(int m, int n)
{
    if (m > n) return;
    if (m % 2 == 0)
    {
        Console.Write($"{m}, ");
    }
    evenNumbers(m + 1, n);
}
evenNumbers(m, n);