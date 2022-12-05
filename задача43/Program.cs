// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void SearchXY(double b1, double k1, double b2, double k2)
{
    double x = 0;
    double y = 0;
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Прямые совпадают");
    }
    else
    {
        if (k1 == k2 || b1 == b2)
        {
            Console.WriteLine("Прямые параллельны");
        }
        else
        {
            x = (b2 - b1) / (k1-k2);
            y = (k1 * x + b1);
            Console.WriteLine($"Прямые пересекутся в точке с координатами X: {x}, Y: {y}");
        }
    }
}

Console.WriteLine("Введи b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи k2");
double k2 = Convert.ToInt32(Console.ReadLine());
SearchXY(b1, k1, b2, k2);