Console.Clear();
int NewNumber(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}
void SquareTable(int N)
{
    int index = 1;
    while (index < N+1)
    {
        double square = Math.Pow(index, 2);
        Console.Write($" {square}");
        index++;
    }
}
int number = NewNumber($"Таблица квадратов чисел до числа ");
SquareTable(number);