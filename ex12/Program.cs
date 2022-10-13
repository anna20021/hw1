// Найти третью цифру числа или сообщить, что её нет
int number = new Random() .Next(100, 1000);
Console. WriteLine(number);
int a = 0;
a = number % 10;

if (a == 0)
{
    Console. WriteLine("нет остатка");
}
else if (a > 0)
{
    Console. WriteLine(a);
}