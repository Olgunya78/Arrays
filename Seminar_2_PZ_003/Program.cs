// Напишите программу, которая принимает на вход цифру, обозначающую день недели и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void variant1()
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
void variant2()
{
int day = 1;
string[] week = {"пн", "вт", "ср", "чт", "пт", "сб", "вс"};
if (day > 0 && day < 8)
{Console.WriteLine(week[day-1]);
if (day == 6 || day == 7) {Console.WriteLine($"выходной день");}
else {Console.WriteLine($"рабочиий день");}
}
else Console.WriteLine($"нет такого дня недели на свете");
}
void variant3()
{
Console.Write("Введите день недели от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());
string[] week = {"пн", "вт", "ср", "чт", "пт", "сб", "вс"};
if (day > 0 && day < 8)
{Console.WriteLine(week[day-1]);
if (day == 6 || day == 7) {Console.WriteLine($"выходной день");}
else {Console.WriteLine($"рабочиий день");}
}
else Console.WriteLine($"нет такого дня недели на свете");
}

// variant1();
variant2();
// variant3();