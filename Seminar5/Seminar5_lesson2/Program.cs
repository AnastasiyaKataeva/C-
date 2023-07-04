// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] newArray = new int[length];

void arrayGenerate(int length)
{
    for (int i = 0; i < length; i++)
{
    newArray[i] = new Random().Next(1,9);
    Console.Write(newArray[i] + "");
}

}

int summEvenNumber(int[] newArray)
{
    int sum = 0;
    int i = 0;
    while (i < newArray.Length)
    {
        sum = sum + newArray[i];
        i = i + 2;
    }
    return sum;
}

arrayGenerate(length);
Console.Write($"\nCумма элементов, стоящих на нечётных позициях: {summEvenNumber(newArray)}");