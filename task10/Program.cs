Console.Write("Введите делимое число: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите делитель: ");
int y = int.Parse(Console.ReadLine());
int a = 0;

if (x % y == 0)
{
    Console.Write(y);
    Console.Write(" является делителем ");
    Console.WriteLine(x);
    a = x / y;
    Console.Write(a);
    Console.Write(" ответ");
}
else
{
    Console.Write(y);
    Console.Write(" не является делителем ");
    Console.WriteLine(x);
    a = x % y;
    Console.Write(a);
    Console.Write(" является остатком от деления ");
}
