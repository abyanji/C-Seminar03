Console.Clear();
double DataEntryXY(string str)
{
    Console.Write(str);
    double number = int.Parse(Console.ReadLine());
    return number;
}

double FindDistance(double x1, double x2, double y1, double y2)
{
    double distance = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
    return distance;
}

double x1 = DataEntryXY("Координаты точки X1: ");
double y1 = DataEntryXY("Координаты точки Y1: ");
double x2 = DataEntryXY("Координаты точки X2: ");
double y2 = DataEntryXY("Координаты точки Y2: ");
double distance = FindDistance(x1, x2, y1, y2);
Console.WriteLine($"Расстояние между точками A и B = {distance}");
    
