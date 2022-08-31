// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 14212 -> нет,  12821 -> да, 23432 -> да.

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string digit = Convert.ToString(number);

if(number >= 10000 && number <= 100000)
{
    if(digit[0]==digit[4] && digit[1]==digit[3])
    {
        Console.WriteLine("Число является палиндромом.");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом.");
    }
}
else
{
    Console.WriteLine("Введено неверное число.");
}