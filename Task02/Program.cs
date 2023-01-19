// Задача 2. По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Введите два числа");
Console.Write("число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("число 2: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 == number2 * number2) Console.WriteLine("Число 1 является квадратом числа 2");
else if (number2 == number1 * number1) Console.WriteLine("Число 2 является квадратом числа 1");
else Console.WriteLine("Ни одно из чисел не является квадратом другого");