// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int x = new Random().Next(100, 1000);
Console.WriteLine(x);
int nam1 = x % 10;
int nam2 = x /100;
Console.Write(nam2);
Console.WriteLine (nam1);