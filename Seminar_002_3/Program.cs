// Напишите программу, которая будет принимать на вход 2 числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// вариант 1
Console.Write("Введите число 1: ");
int nam1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int nam2 = Convert.ToInt32(Console.ReadLine());
int i = nam1 % nam2;
if (i > 0) {Console.WriteLine($"Вышло, что {nam1} некратно {nam2}, остаток {i}");}
else {Console.WriteLine($"Вышло, что {nam1} кратно {nam2}");} 


// вариант 2
// Console.Write("Введите число 1: ");
// int nam1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 2: ");
// int nam2 = Convert.ToInt32(Console.ReadLine());
// int i = nam1 % nam2;
// if (i > 0) {Console.WriteLine($"остаток {i}");}
// else {Console.WriteLine($"Кратно");}