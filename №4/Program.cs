﻿ //Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int even = 2;
if(a > 1)
{
    while(even <= a)
    {
        Console.WriteLine(even+ " ");
        even = even+ 2;
    }
}
