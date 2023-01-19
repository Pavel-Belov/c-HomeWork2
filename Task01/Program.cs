// Задача 1. Дано число обозначающее день недели. Выяснить является номер дня недели выходным

int day = new Random().Next(1, 8);
Console.Write("Случайно выбранный день недели: ");
Console.WriteLine(day);

if (day > 5)
{
    Console.Write("Является выходным. ");

    if (day == 6) Console.WriteLine("Это суббота");
    else Console.WriteLine("Это воскресенье");
}
else
{
    Console.WriteLine("Не является выходным");
}