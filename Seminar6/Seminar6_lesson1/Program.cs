// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int prompt(string message)
{
    System.Console.Write(message);
    string promptMessage = Console.ReadLine();
    int value = Convert.ToInt32(promptMessage);
    return value;
}

int[] arrayInput(int length)
{
    int[] array = new int[length];
    for( int i = 0; i < array.Length; i++)
    {
       array[i] = prompt($"Введите {i+ 1} -й элемент: ");
    }
    return array;
}
void printArray(int[] array)
{
    for( int i = 0; i < array.Length; i++) {
        System.Console.WriteLine($"{array[i]}");

        // System.Console.Write($"a[{i}] = {array[i]}");
    }
}
int positiveNambers(int[] array)
{
    int count = 0;
    for( int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int length = prompt("Введите количество элементов: ");
int[] array;
array = arrayInput(length);
printArray(array);
System.Console.WriteLine($"Пользователь ввел {positiveNambers(array) } элементов больше 0");