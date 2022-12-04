Console.Clear();
int DataEntrySquare(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}
void FindXY(int square)
{
    if (square == 1) Console.WriteLine("x > 0 and y > 0");
    if (square == 2) Console.WriteLine("x < 0 and y > 0");
    if (square == 3) Console.WriteLine("x < 0 and y < 0");
    if (square == 4) Console.WriteLine("x > 0 and y < 0");
    if (square < 1 || square > 4) Console.WriteLine("Недопустимое значение");
}

int square = DataEntrySquare("Введите номер четверти = ");
FindXY(square);