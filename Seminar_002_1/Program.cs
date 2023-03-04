// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа
// 78 -> 8
// 12 -> 2
// 85 -> 8

void zadacha91()
{
int x = new Random().Next(10, 100);
Console.WriteLine(x);
int nam1 = x % 10;
int nam2 = (x - nam1) /10;
if (nam1 == nam2) {Console.WriteLine($"{nam1} равно {nam2}");}
else if (nam1 > nam2) {Console.WriteLine($"{nam1} больше, {nam2} меньше");}
else {Console.WriteLine($"{nam2} больше, {nam1} меньше");}
}

void zadacha92()
{
int x = new Random().Next(10, 100);
Console.WriteLine(x);
int nam1 = x / 10;
int nam2 = x % 10;
if (nam1 == nam2) {Console.WriteLine($"{nam1} равно {nam2}");}
else if (nam1 > nam2) {Console.WriteLine($"{nam1} больше, {nam2} меньше");}
else {Console.WriteLine($"{nam2} больше, {nam1} меньше");}
}

void zadacha9()
{
Random random = new Random();
int namber = random.Next(10, 100);
Console.WriteLine(namber);
int tens = namber / 10;
int ones = namber % 10;
if (tens == ones) {Console.WriteLine($"{tens} равно {ones}");}
else if (tens > ones) {Console.WriteLine($"{tens} больше, {ones} меньше");}
else {Console.WriteLine($"{ones} больше, {tens} меньше");}
}

zadacha91();
zadacha92();
zadacha9();