Console.Write("Введите трехзначное число: ");
int x = int.Parse(Console.ReadLine());
int y = 0;

if (x < -99 && x >-1000)
{
    Console.Write("Вывожу поледнюю цифру введенного числа: ");
    y = x % 10;
    Console.Write(-y);
}
else if (x > 99 && x <1000)
{
    Console.Write("Вывожу поледнюю цифру введенного числа: ");
    y = x % 10;
    Console.Write(y);
}
else
{
    Console.Write("Вы ввели некоректное число ");
}