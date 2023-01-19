// Задача 3. Задать номер четверти, показать диапазоны для возможных координат

Console.Write("Задайте номер четверти: ");
int value = int.Parse(Console.ReadLine()!);

if (value == 1)
{
    Console.WriteLine("Диапазон координат в первой четверти: x > 0, y > 0");
}
else if (value == 2)
{
    Console.WriteLine("Диапазон координат во второй четверти: x < 0, y > 0");
}
else if (value == 3)
{
    Console.WriteLine("Диапазон координат в третьей четверти: x < 0, y < 0");
}
else if (value == 4)
{
    Console.WriteLine("Диапазон координат в четвёртой четверти: x > 0, y < 0");
}
else
{
    Console.WriteLine("Ошибка! Номер четверти должен быть от 1 до 4!");   
}