/*
Задача 21. 
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

*/

Console.Write("Введите координату x первой точки: ");

float x1 = float.Parse(Console.ReadLine());

Console.Write("Введите координату y первой точки: ");

float y1 = float.Parse(Console.ReadLine());

Console.Write("Введите координату z первой точки: ");

float z1 = float.Parse(Console.ReadLine());

Console.Write("Введите координату x второй точки: ");

float x2 = float.Parse(Console.ReadLine());

Console.Write("Введите координату y второй точки: ");

float y2 = float.Parse(Console.ReadLine());

Console.Write("Введите координату z второй точки: ");

float z2 = float.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));

Console.WriteLine($"Расстояние между точками равно {distance}");
