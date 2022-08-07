Console.WriteLine("Введите день (1-7): ");
string day = Console.ReadLine();

if (day == "1")
{
Console.Write("Monday");
}
 if (day == "2")
 {
    Console.Write("Tuesday");
 }
 if (day == "3")
 {
    Console.Write("Wednesday");
 }
 if (day == "4")
 {
    Console.Write("Thursday");
 }
 if (day == "5")
 {
    Console.Write("Friday");
 }
 if (day == "6")
 {
   Console.Write("Saturday"); 
 }
 if (day == "7")
 {
    Console.Write("Sunday");
 }
else 
{
    Console.Write("Данное число является не корректеым по отношению к дням недели. ");
}