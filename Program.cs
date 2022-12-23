// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
Console.WriteLine("Введите пятизначное число:");
int num = int.Parse(Console.ReadLine());
int num5 = 0;
int num4 = 0;
int num2 = 0;
int num1 = 0;
int n = num;
if (num < 0)
{
    num = num * -1;
}
if (num < 10000 || num > 99999)
{
        Console.Write("Вы ввели не пятизначное число");
        return;
}
num5 = num % 10;
num4 = (num / 10) % 10;
num2 = (num / 1000) % 10;
num1 = (num / 10000) % 10;

if (num5 == num1 && num4 == num2)
{
    Console.Write($"{n} палиндром");
}
else
{
    Console.Write($"{n} не палиндром");
}