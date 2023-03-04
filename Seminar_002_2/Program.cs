// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

void zadacha1()
{// вариант 1
int x = new Random().Next(100, 1000);
Console.WriteLine(x);
int nam1 = x / 100;
int nam2 = x % 10;
Console.Write(nam1);
Console.WriteLine (nam2);
}
void zadacha2()
{// вариант 2
int x = new Random().Next(100, 1000);
Console.WriteLine(x);
int nam1 = x / 100;
int nam2 = x / 10;
int nam3 = x % 10;
Console.WriteLine($"{nam1}{nam3}");
}
void zadacha3()
{// вариант 3
int x = new Random().Next(100, 1000);
int nam1 = x / 100;
int nam2 = x % 10;
string c = Convert.ToString (nam1) + Convert.ToString (nam2);
Console.WriteLine(x);
Console.WriteLine (c);
}
void zadacha4()
{
int x = new Random().Next(100, 1000);
Console.WriteLine(x);
int handers = x / 100;
int nam1 = x / 10;
int nam2 = x % 10;
Console.WriteLine(handers * 10 + nam2);
}

zadacha1();
zadacha2();
zadacha3();
zadacha4();