﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int index = 1;
Console.WriteLine();

while(index <= number)
{
    double result = Math.Pow(index,3);
    Console.WriteLine(result);
    index++;
}
