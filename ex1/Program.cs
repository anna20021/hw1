// По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine ("number A");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine ("number B");
int numberB = int.Parse(Console.ReadLine());

if (numberA*numberA == numberB)
{
Console.WriteLine("yes");
}
else 
Console.WriteLine ("no");