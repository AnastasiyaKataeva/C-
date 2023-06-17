// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ReadInput(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int ThirdNum(int number)
{
    while(number > 999)
    {
       number /= 10;
    }
    return number % 10;
}

bool ValidateNumber(int number)
{
    if (number < 100)
    {
        System.Console.WriteLine("третьей цифры нет");
        return false;
    }
    return true;
}
int num = ReadInput("Введите число > ");
if (ValidateNumber(num))
{
    System.Console.WriteLine($"Tретья цифра числа {num} равна {ThirdNum(num)}");
}