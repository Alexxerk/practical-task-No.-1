Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());
int y = 10;
int count = 0;
int z = 0;

while(x / y != 0)
{
    y = y * 10;
    count = count + 1;
}

if (count < 2)
{
    Console.Write("Число меньше трехзначного ");
}
else
{

z = 3 - count;
z = -z + 1;

 while(z != 0)
 {
     x = x / 10;
     z = z - 1;
 }

 z = x % 10;
 Console.Write("Третья цифра числа == ");
 Console.Write(z);
}




