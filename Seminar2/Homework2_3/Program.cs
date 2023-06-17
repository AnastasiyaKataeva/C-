// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int InputWeekDay(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

bool ValidateDayWeek (int number)
{

    if (number > 0 && number <= 7)
    {
        if (number > 0 && number < 6)
        {
            System.Console.WriteLine("Это рабочий день");
            return false;
        }
        else
        {
            return true;
        }
    }
    else {
        System.Console.WriteLine("Такого дня нет");
        return false;
    }
}

int weekDay = (InputWeekDay("Введите день недели"));
if (ValidateDayWeek(weekDay))
{
    System.Console.WriteLine("Этот день выходной.");
}
