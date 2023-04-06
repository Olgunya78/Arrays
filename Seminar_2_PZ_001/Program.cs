// Напишите программу, которая принимает на вход трехзначное число, а на выходе показывает вторую цифру этого числа. 
// 456 -> 5
// 782 -> 8
// 918 -> 1 

void variant1()  // этот вариант не работает при введении более, чем 3 чисел
{
Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int second = n / 10 % 10;
Console.WriteLine($"Вторая цифра числа: {second}");
}

// в задаче int n = 123 - означает, что число состоит из 3 знаков чисел
void variant2()
{
int n = 1237;
if (n > 99 && n < 1000) Console.Write("Вторая цифра числа " + (n/10%10));
else Console.Write("Введено не трехзначное число ");
}

void variant3()
{
Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 99 && n < 1000)
{
  int n2 = (n % 100) / 10;
  Console.WriteLine ($"Вторая цифра числа {n2}");
}
 else Console.WriteLine("Введено не трехзначное число ");
}

void variant4()  // не работает этот вариант с введением более 3-х чисел
{
Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = (n % 100 - n % 10) / 10;
Console.WriteLine ($"Вторая цифра числа {result}");
}

// variant1();
// variant2();
// variant3();
// variant4();
