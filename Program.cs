// Напишите программу ,которая на вход принимает число и выдает его квадрат
// Натуральные числа unsigned int
// Целые числа int
// Дробный числа double (float)

int a = 0;
Console.Write($"Введите число: ");
string userEnter = Console.ReadLine()!;

int.Parse(userEnter);

int b = a * a;

b = (int)Math.Pow(a, 2);

Console.Write($"{a} ^ 2 = {b}");