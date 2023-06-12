Console.Write("Введите первое число ");
string inputedFirstNum = Console.ReadLine();
int firstNumber = Convert.ToInt32(inputedFirstNum);
Console.Write("Введите второе число ");
string inputedSecondNum = Console.ReadLine();
int secondNumber = Convert.ToInt32(inputedSecondNum);
Console.Write("Введите третье число ");
string inputedThirdNum = Console.ReadLine();
int thirdNumber = Convert.ToInt32(inputedThirdNum);

int max = firstNumber;

if (secondNumber > max) {
     max = secondNumber;
};
if (thirdNumber > max) {
     max = thirdNumber;
};
Console.Write($"Число {max} наибольшее");
