int x = new Random().Next(10, 100);
Console.Write("Число ");
Console.WriteLine(x);

int max = 0;

int y = x / 10;
int z = x % 10;

if (y > z)
{
    max = y;
    Console.WriteLine("Наибольшее из двух цифр числа == ");
    Console.Write(max);
}
else if (y < z)
{
    max = z;
    Console.WriteLine("Наибольшее из двух цифр числа == ");
    Console.Write(max);
}
else 
{
    Console.WriteLine("Цифры входящие в число равны ");
}


