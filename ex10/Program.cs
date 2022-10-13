//Удалить вторую цифру трёхзначного числа
int number = new Random() .Next(100, 1000);
Console. WriteLine(number);
int a = 0;
int b = 0;
int c = 0;
int d = 0; 
a = number / 100; 
b = number / 10;
b = b % 10;
c = number % 10;
d = a* 10 + c ;
Console. WriteLine(d);