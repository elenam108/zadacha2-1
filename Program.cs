// Напишите программу, которая принимает на вход трёхзначное число и на выходе 
//показывает вторую цифру этого числа. Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите число ");
int x=Convert.ToInt32 ( Console.ReadLine());
int y=x%100;
int a=y/10;
//Console.WriteLine(y);
Console.WriteLine($"{a}");
