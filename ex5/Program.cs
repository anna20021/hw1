// Показать числа от -N до N
Console.WriteLine("enter the number");
int number = int.Parse(Console.ReadLine());
int number1 = (number) * (-1);

while (number1<=number)
{
    int x = number1++;
    Console.WriteLine(x); 
}