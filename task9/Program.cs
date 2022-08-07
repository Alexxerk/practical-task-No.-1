Console.Write("Введите трехзначное число: ");
int x = int.Parse(Console.ReadLine());
int y = 0;
int z = 0;

if (x < -99 && x >-1000)
{
    Console.Write("Первая и последняя цифра трехзначного числа ");
    y = x / 100;
    z = x % 10;
    Console.Write(y);
    Console.Write(-z);
}
else if (x > 99 && x <1000)
{
    Console.Write("Первая и последняя цифра трехзначного числа ");
    y = x / 100;
    z = x % 10;
    Console.Write(y);
    Console.Write(z);
}
else
{
   Console.Write("Вы ввели некоректное число "); 
}
