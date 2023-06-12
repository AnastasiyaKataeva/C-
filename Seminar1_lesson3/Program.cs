Console.WriteLine("Введите число:");
string inputedNum = Console.ReadLine();
int number = Convert.ToInt32(inputedNum);
if (number % 2 == 1) {
    Console.WriteLine("Число " + number + " нечётное");
} else {
    Console.WriteLine("Число " + number + " чётное");
};