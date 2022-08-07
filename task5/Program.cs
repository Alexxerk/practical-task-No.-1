Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());
int x = (-n - 1);

while(x < (n - 1))
{
    x = x + 1;
    Console.Write(x);
    Console.Write(", ");
}
Console.Write(n);
