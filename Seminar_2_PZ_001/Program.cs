// Напишите программу, которая принимает на вход трехзначное число, а на выходе показывает вторую цифру этого числа. 
// 456 -> 5
// 782 -> 8
// 918 -> 1 

void zadacha1()
{
Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int second = n / 10 % 10;
Console.WriteLine($"{second}");
}

// в задаче int n = 123 - означает, что число состоит из 3 знаков чисел
void zadacha2()
{
int n = 1237;
if (n > 99 && n < 1000) Console.Write("Вторая цифра числа " + (n/10%10));
else Console.Write("Введено не трехзначное число ");
}

// zadacha1();
zadacha2();