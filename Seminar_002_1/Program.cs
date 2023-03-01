// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа
// 78 -> 8
// 12 -> 2
// 85 -> 8

// вариант 1

// int x = new Random().Next(10, 100);
// Console.WriteLine(x);
// int nam1 = x % 10;
// int nam2 = (x - nam1) /10;
// if (nam2 == nam1) {Console.WriteLine($"{nam2} равно {nam1}");}
// else if (nam1 > nam2) {Console.WriteLine($"{nam1} больше");}
// else if (nam2 > nam1) {Console.WriteLine($"{nam2} больше");}


// вариант 2
int x = new Random().Next(10, 100);
Console.WriteLine(x);
int nam1 = x / 10;
int nam2 = x % 10;
if (nam2 == nam1) {Console.WriteLine($"{nam2} равно {nam1}");}
else if (nam1 > nam2) {Console.WriteLine($"{nam1} больше");}
else if (nam2 > nam1) {Console.WriteLine($"{nam2} больше");}
