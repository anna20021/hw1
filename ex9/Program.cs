// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int number = new Random() .Next(10, 99);
Console. WriteLine(number);
int a = 0;
int b = 0; 
a = number / 10; 
a = a % 10;
b = number % 10;
if (a > b)
{
    Console. WriteLine(a);
}
if (a < b)
{
    Console. WriteLine(b);
}