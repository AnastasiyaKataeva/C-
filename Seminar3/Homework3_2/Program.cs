// Задача 2
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int ReadInput(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int x1 = ReadInput("Введите координату х первой точки: ");
int x2 = ReadInput("Введите координату х второй точки: ");
int y1 = ReadInput("Введите координату y первой точки: ");
int y2 = ReadInput("Введите координату y второй точки: ");
int z1 = ReadInput("Введите координату z первой точки: ");
int z2 = ReadInput("Введите координату z втоой точки: ");

double length(int x, int y, int z)
{
    double temp = (x * x) + (y * y) + (z * z);
    return Math.Sqrt(temp);
}

double distance = length(x2 - x1, y2 - y1, z2 - z1);
System.Console.WriteLine($"Расстояние между координатами двух точек равно: {distance}");