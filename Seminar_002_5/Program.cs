// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет

void zadacha1()
{
// вариант рабочий
Console.Write("Введите число 1: ");
int nam1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int nam2 = Convert.ToInt32(Console.ReadLine());
if (nam1 == nam2 * nam2) Console.WriteLine($"{nam1} это квадрат {nam2}");
else Console.WriteLine($"{nam1} не является квадратом {nam2}");
if (nam2 == nam1 * nam1) Console.WriteLine($"{nam2} это квадрат {nam1}");
else Console.WriteLine($"{nam2} не является квадратом {nam1}");
}
void zadacha2()
{
// вариант 2 - рабочий
Console.Write("Введите число 1: ");
int nam1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int nam2 = Convert.ToInt32(Console.ReadLine());
if (nam1 == nam2 * nam2 || nam2 == nam1 * nam1) Console.WriteLine($"Одно число является квадратом другого");
else Console.WriteLine($"одно число не является квадратом другого");
}
void zadacha3()
{
// вариант решения с функцией
Console.Write("Введите число 1: ");
int nam1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int nam2 = Convert.ToInt32(Console.ReadLine());
if (nam1 == Math.Pow(nam2, 2) || nam2 == Math.Pow(nam1, 2)) Console.WriteLine($"Одно число является квадратом другого");
else Console.WriteLine($"одно число не является квадратом другого");
}
void zadacha4()
{
// еще вариант решения с функцией
int input()
{
Console.Write("Введите число: ");
return Convert.ToInt32(Console.ReadLine());
}
int nam1= input();
int nam2 = input();
if (nam1 == Math.Pow(nam2, 2) || nam2 == Math.Pow(nam1, 2)) Console.WriteLine($"Одно число является квадратом другого");
else Console.WriteLine($"одно число не является квадратом другого");
}

// zadacha1();
// zadacha2();
// zadacha3();
zadacha4();