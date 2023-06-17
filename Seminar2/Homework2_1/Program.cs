// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


int ReadInr(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
bool Validate3sign (int number)
{
    if (number >= 100 && number < 1000)
    {
        return true;
    }
    System.Console.WriteLine("Число не трёхзначное");
    return false;

}

int num = ReadInr ("Введите  трёхзначное число > ");
if (Validate3sign(num))
{
    int secondNum =  ((num / 10) % 10);
    System.Console.WriteLine($"Вторая цифра числа {num} равна {secondNum}");
}