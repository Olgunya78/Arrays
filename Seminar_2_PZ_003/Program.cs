// Напишите программу, которая принимает на вход цифру, обозначающую день недели и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void zadacha1()
{
Console.Write("Введите день недели от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0 && day < 8)
{
if (day == 6 || day == 7) {Console.WriteLine($"выходной день");}
else {Console.WriteLine($"рабочиий день");}
}
else Console.WriteLine($"нет такого дня недели на свете");
}
zadacha1();