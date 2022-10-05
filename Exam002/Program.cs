double b1 = Dot(" b1: ");
double k1 = Dot(" k1: ");
double b2 = Dot(" b2: ");
double k2 = Dot(" k2: ");
double x = 0;
double y = 0;

double Dot(string mean)
{
    Console.Write("Введите значение точки" + mean);
    return double.Parse(Console.ReadLine()); 
}

if (k1 == k2 & b1 == b2)
{
    Console.WriteLine("Прямые совпадают");
}
else
{
    if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
        Math.Round(x = (b2-b1)/(k1-k2), 2);
        Math.Round(y= k1 * x + b1, 2);
    }
}

Console.WriteLine(String.Format("Точка пересечения прямых ({0:0.00}; {1:0.00})", x, y));