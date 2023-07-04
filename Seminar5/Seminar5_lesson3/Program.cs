// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] generateNewArray(int length)
{
    double[] list = new double [length];
    Random num = new Random();
    for (int i = 0; i < list.Length; i++)
    {
        list[i] = num.Next(0, 100) + num.NextDouble();
    }
    return list;
}

void printArray(double[] newArray)
{
    for ( int i = 0; i < newArray.Length; i++)
    {
        System.Console.Write(newArray[i] + " ");
    }
}

double Max(double[] list)
{
    double max = list[0];
    for(int i = 0; i <list.Length; i++)
    {
        if(max < list[i])
        {
            max = list[i];
        }
    }
    return max;
}

double Min(double[] list)
{
    double min = list[0];
    for(int i = 0; i <list.Length; i++)
    {
        if(min > list[i])
        {
            min = list[i];
        }
    }
    return min;
}

double[] list = generateNewArray(6);
printArray(list);
double min = Min(list);
double max = Max(list);
System.Console.WriteLine($" Разница между минимальным и максимальным элементом массива равна  { max - min} ");