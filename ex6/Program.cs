// Показать четные числа от 1 до N
Console.WriteLine ("enter the number");
int number = int.Parse (Console.ReadLine());
int x = 1; 
while (x<=number)
{
    
if (x % 2 == 0)
{
Console.WriteLine(x);
}
x = x+ 1;
}