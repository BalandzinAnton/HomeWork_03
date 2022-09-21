// Задача 21. Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

using static System.Console;
Clear();
Write("Введите координату X1: ");
int X1 = int.Parse(ReadLine()!);
Write("Введите координату Y1: ");
int Y1 = int.Parse(ReadLine()!);
Write("Введите координату Z1: ");
int Z1 = int.Parse(ReadLine()!);

Write("Введите координату X2: ");
int X2 = int.Parse(ReadLine()!);
Write("Введите координату Y2: ");
int Y2 = int.Parse(ReadLine()!);
Write("Введите координату Z2: ");
int Z2 = int.Parse(ReadLine()!);

double length = Math.Sqrt(Math.Pow(X2-X1,2) + Math.Pow(Y2-Y1, 2) + Math.Pow(Z2-Z1, 2));
WriteLine($"{length:f2}");
