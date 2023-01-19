// Задача 4. Найти расстояние между точками в пространстве 2D/3D

Console.WriteLine("Выберите пространство");
Console.WriteLine("Для работы в 2D пространстве нажмите 2. Для работы в 3D пространстве нажмите 3");
int enterVar = int.Parse(Console.ReadLine());

if (enterVar < 2 || enterVar > 3)
{
    Console.WriteLine("Ошибка! Вы не выбрали рабочее пространство!");
}
else
{
    double[] point1 = new double[enterVar];
    double[] point2 = new double[enterVar];
    double power = 2;
    double distance = 0;

    Console.WriteLine("Введите координаты первой точки: ");
    int i = 0;
    while (i < enterVar)
    {
        point1[i] = double.Parse(Console.ReadLine());
        i++;
    }

    i = 0;
    Console.WriteLine("Введите координаты второй точки: ");
    while (i < enterVar)
    {
        point2[i] = double.Parse(Console.ReadLine());
        i++;
    }

    double distanceX = Math.Pow(Math.Abs(point1[0] - point2[0]), power);
    double distanceY = Math.Pow(Math.Abs(point1[1] - point2[1]), power);

    if (enterVar == 2)
    {
        distance = Math.Sqrt(distanceX + distanceY);
        Console.WriteLine("расстояние между точками равно: " + distance);
    }
    else if (enterVar == 3)
    {
        double distanceZ = Math.Pow(Math.Abs(point1[2] - point2[2]), power);
        distance = Math.Sqrt(distanceX + distanceY + distanceZ);
        Console.WriteLine("расстояние между точками равно: " + distance);
    }
}