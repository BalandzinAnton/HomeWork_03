// Задача 19. Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

using static System.Console;
Clear();

WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int a1 = number/10000; // a1a2a3a4a5
int a5 = number%10;
int a4 = (number%100-a5)/10;
int a2 = number/1000-a1*10;
if (a1==a5 && a2==a4)
{
    WriteLine("Число является палиндромом");
}
else
{
    WriteLine("Число не является палиндромом");
}
