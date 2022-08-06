Console.Write("Введите 1 число: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите 2 число: ");
int y = int.Parse(Console.ReadLine());
int c = y * y;

if (x == c)
{
    Console.Write(x);
    Console.Write(" является квадратом числа ");
    Console.Write(y);
}
else
{
    Console.Write(x);
    Console.Write(" не является квадратом числа ");
    Console.Write(y);
}