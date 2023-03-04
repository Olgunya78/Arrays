// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
// 14 -> нет
// 46 -> нет
// 161 -> да

void zadacha1()
{
Console.Write("Введите число: ");
int nam = Convert.ToInt32(Console.ReadLine());
int x = nam % 7;
int y = nam % 23;
if (x == 0 & y == 0) {Console.WriteLine ($"Число {nam} кратно и 7 и 23");}
else {Console.WriteLine($"Число {nam} некратно одновременно 7 и 23");}
}
void zadacha2()
{
Console.Write("Введите число: ");
int nam = Convert.ToInt32(Console.ReadLine());
if (nam % 7 == 0 && nam % 23 == 0) Console.WriteLine ($"Число {nam} кратно и 7 и 23");
else Console.WriteLine ($"Число {nam} некратно одновременно 7 и 23");
}
zadacha1();
zadacha2();