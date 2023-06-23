// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// (*) В 3-й задаче Доп сложность. Ввод с консоли “введите количество элементов массива”, “Введите минимальный порог случайных значений”, “Введите максимальный порог случайных значений”

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

int max = Prompt("Введите количество элементов массива: ");
int randomMax = Prompt("Введите максимальный порог значений");
int randomMin = Prompt("Введите минимальный порог значений");


int [] array = new int[max];

for( int index = 0; index < max; index++)
{
    while (true)
    {
        System.Console.WriteLine("Введите значение");
        int value = Convert.ToInt32(Console.ReadLine());

        if(value >= randomMin && value <= randomMax) {
            array[index] = value;
            break;
        }

        System.Console.WriteLine("Значение выходит за пороговое значение!");
    }

}
System.Console.WriteLine(string.Join(", ", array));
