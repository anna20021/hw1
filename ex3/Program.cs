// Найти максимальное из трех чисел
int numberA = new Random() .Next(1, 100);
Console. WriteLine(numberA);
int numberB = new Random() .Next(1, 100); 
Console.WriteLine(numberB);
int numberC = new Random() .Next(1, 100);
Console. WriteLine(numberC);
if (numberA> numberB) 
if (numberA>numberC)
{
    Console.WriteLine(numberA);
}
if (numberB> numberA) 
if (numberB>numberC)
{
    Console.WriteLine(numberB);
}if (numberC> numberB) 
if (numberC>numberA)
{
    Console.WriteLine(numberC);
}