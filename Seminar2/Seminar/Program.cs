// напишите программу, которая на вход принимает трёхзначное число и на выходе показывает последнюю цифру этого числа
// 456 (6)
// 782 (2)
// 981 (8)


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
    int lastNum =  num % 10;
    System.Console.WriteLine($"Последняя цифра числа {num} равна {lastNum}");
}

// Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа


int number1 = new Random().Next(10,99);
System.Console.WriteLine(number1);

int number2 = number1 / 10;
System.Console.WriteLine(number2);

int number3 = number1 % 10;
System.Console.WriteLine(number3);

if (number2 > number3)
{
    System.Console.WriteLine($"Число { number2}, больше чем { number3}");
} else
{
    System.Console.WriteLine($"Число { number3}, больше чем { number2}");
}

// Напишите программу, которая будет принимать на вход два числа и выводить , является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

int ReadInt(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int number_1 = ReadInt("Введите первое число > ");
int number_2 = ReadInt("Введите второе число > ");

int result = number_2 % number_1;

if (result == 0)
{
    System.Console.WriteLine($"Число {number_2} кратно числу {number_1}");
} else
{
    System.Console.WriteLine($"Остаток от деления числа {number_2} на число {number_1} равен {result}");
}


// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

int ReadNumber(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
int numb = ReadNumber("Введите число > ");

if (numb % 7 == 0 && numb % 23 == 0)
{
    System.Console.WriteLine($"Число {numb} кратно числам 7 и 23");
} else
{
    System.Console.WriteLine($"Число {numb}  не кратно числам 7 и 23");
}

// Напишите программу, которая выводит случайное число из отрезка [10, 9999] и показывает наибольшую цифру из числа

int MaxDigit(int number)
{
    int max = 0;
    while(number > 0)
    {
        int rest10 = number % 10;
        if ( rest10 > max)
        {
            max = rest10;
        }
        number /= 10;
    }
    return max;
}

int number = new Random().Next(10, 10000);
int maxDigit = MaxDigit(number);
System.Console.WriteLine($" {number} -> {maxDigit}");