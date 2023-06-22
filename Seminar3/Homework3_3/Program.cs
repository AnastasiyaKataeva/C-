// Задача 3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int ReadInput(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int number = ReadInput("Введите  целое число: ");

int iterator = 0;
int cube = 0;
while (iterator <= number)
{
    cube = (iterator * iterator * iterator);
    iterator++;
    System.Console.WriteLine($"{cube}");
}
