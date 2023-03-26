// Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет
// 645 -> 5
// 78  ->  третьей цифры нет
// 3267432979 -> 6


void variant1()
{
Console.Write("Введите число: ");
int numb = Convert.ToInt32(Console.ReadLine());
if (numb > 99) 
{
  while (numb >= 999) 
{numb /= 10;}
Console.WriteLine($"Третья цифра числа {numb % 10}");
}
else Console.WriteLine($"третьей цифры нет");
}
void variant2()
{
int numb = 324789;
numb = Math.Abs(numb);
if (numb > 99) 
{
  while (numb >= 999) 
{numb /= 10;}
Console.WriteLine("Третья цифра числа " + numb % 10);
}
else Console.WriteLine($"третьей цифры нет");
}
void variant3()
{
string numb = "1234567";
Console.WriteLine("Третья цифра числа " + numb [2]);
}
void variant4()
{
string numb = "1234567";
var n = numb[2] + numb[1];
Console.WriteLine(n);
}
// variant1();
// variant2();
// variant3();
variant4();