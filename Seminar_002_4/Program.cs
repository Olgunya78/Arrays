﻿// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
// 14 -> нет
// 46 -> нет
// 161 -> да


Console.Write("Введите число: ");
int nam = Convert.ToInt32(Console.ReadLine());
int x = nam % 7;
int y = nam % 23;
if (x == 0 & y == 0) {Console.WriteLine ($"Число кратно и 7 и 23");}
else {Console.WriteLine($"Число некратно одновременно 7 и 23");}
