// Задача 23. Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

using static System.Console;
Clear();
Write("Введите число: ");
int number = int.Parse(ReadLine()!);
int count = 1;
if (number<=0)
{
    WriteLine("Error!");
    return;
}
while (number>=count)
{
    WriteLine(Math.Pow(count,3));
    count++;
}
