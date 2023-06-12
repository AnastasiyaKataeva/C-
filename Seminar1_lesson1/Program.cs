Console.Write("Введите первое число ");
string inputedFirstNum = Console.ReadLine();
int firstNumber = Convert.ToInt32(inputedFirstNum);
Console.Write("Введите второе число ");
string inputedSecondNum = Console.ReadLine();
int secondNumber = Convert.ToInt32(inputedSecondNum);

if (firstNumber > secondNumber) {
    Console.Write($"Число {firstNumber} больше чем {secondNumber}");
} else {
    Console.Write($"Число {secondNumber} больше чем {firstNumber}");
};