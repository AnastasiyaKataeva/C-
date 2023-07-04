int lenghtArray()
{
    System.Console.WriteLine("Задайте длину массива: ");
    int lengthArray = Convert.ToInt32(Console.ReadLine());
    return lengthArray;
}
int[] generateNewArray(int length, int min, int max)
{
    int[] list1 = new int [length];
    Random num = new Random();
    for (int i = 0; i < list1.Length; i++)
    {
        list1[i] = num.Next(min, max + 1);
    }
    return list1;
}

void printArray(int[] newArray)
{
    for ( int i = 0; i < newArray.Length; i++)
    {
        System.Console.Write(newArray[i] + " ");
    }
}

int evenOfNumbers(int[] newArray)
{
    int number = 0;
    for ( int i = 0; i < newArray.Length; i++)
    {
        if(newArray[i] % 2 == 0)
        {
            number = number + 1;
        }
    }
    return number;
}
int num = lenghtArray();
int[] numberlists = generateNewArray(num, 100, 999);
int quantity = evenOfNumbers(numberlists);

printArray(numberlists);
System.Console.Write($"Количество чётных чисел в массиве - {quantity}");
