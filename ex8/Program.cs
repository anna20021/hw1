// Показать вторую цифру трёхзначного числа
Console.WriteLine("enter the number");
int number = int.Parse (Console.ReadLine());
int a = 0;
a = number / 10; 
a= a % 10;
Console.WriteLine(a);

