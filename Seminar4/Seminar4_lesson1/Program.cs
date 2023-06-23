// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInput(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int a = ReadInput("Введите первое число: ");
int b = ReadInput("Введите второе число: ");

int c = 1;


if(b > 0 && a > 0 )
{
    for (int i = 1; i <= b; i++)
    {
        c = c * a;
    }
    System.Console.WriteLine($"Число а в натуральной степени числа b равно: {c} ");
}
else
{
    System.Console.WriteLine("Введите положительные числа!");
}
