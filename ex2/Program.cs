// По заданному номеру дня недели вывести его название
Console.WriteLine ("enter number from 1 till 7");
int number = int.Parse(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine("monday");
}
if (number == 2)
{
    Console.WriteLine("tuesday");
}
if (number == 3)
{
    Console.WriteLine("wendsday");
}
if (number == 4)
{
    Console.WriteLine("thursday");
}
if (number == 5)
{
    Console.WriteLine("friday");
}
if (number == 6)
{
    Console.WriteLine("saturday");
}
if (number == 7)
{
    Console.WriteLine("sunday");
}
else 
{
    Console.WriteLine("wrong number");
}