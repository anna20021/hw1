// Выяснить, кратно ли число заданному, если нет, вывести остаток.
int numberA = new Random() .Next(10,1000);
Console. WriteLine(numberA);
Console.WriteLine("numberB");
int numberB = int.Parse (Console.ReadLine());
int a = 0;
int b = 0;

if (numberA % numberB == 0)
{
    a= (numberA % numberB);
   Console. WriteLine("a"); 
}
else if (numberA % numberB != 0)
{
    b= numberA % numberB;
Console. WriteLine(b);
}