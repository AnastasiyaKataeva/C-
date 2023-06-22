// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


int ReadInput(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int Reverse (int number) {
    int reverse = 0;
    while (number > 0)
    {
        reverse = reverse * 10 + number % 10;
        number /= 10;
    }
    return reverse;
}

int number = ReadInput("Введите целое пятизначное число ");

int reverse = Reverse(number);

if (reverse == number)
{
    System.Console.WriteLine($"{number} является палиндромом");
}
else
{
    System.Console.WriteLine($"{number}  не является палиндромом");
}