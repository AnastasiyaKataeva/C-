// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    string inputedString = Console.ReadLine();
    int value;

    if (int.TryParse(inputedString, out value))
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число!");
    Environment.Exit(0);
    return 0;
}

int number = Prompt("Введите число: ");
System.Console.WriteLine(number);

int lengthNumber(int number)
{
    int index = 0;
    for(; number > 0; index++)
    {
        number /= 10;
    }
    return index;
}

int Sum(int number)
{
    int length = lengthNumber(number);
    int sumNumber = 0;
    for (int index = 1; index <= length; index++)
    {
        sumNumber += number % 10;
        number /= 10;
    }
    return sumNumber;
}

System.Console.WriteLine(Sum(number));
