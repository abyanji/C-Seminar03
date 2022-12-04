Console.Clear();
int DataEntryXY(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}
void FindQuandrat(int x, int y)
{
    if (x > 0 && y > 0) Console.WriteLine("Это первый квадрат");
    if (x < 0 && y > 0) Console.WriteLine("Это второй квадрат");
    if (x < 0 && y < 0) Console.WriteLine("Это третий квадрат");
    if (x > 0 && y < 0) Console.WriteLine("Это четвертый квадрат");
}


int x = DataEntryXY("Введите координаты x = ");
// Console.WriteLine(x);
int y = DataEntryXY("Введите координаты y = ");
// Console.WriteLine(y);

FindQuandrat(x, y);