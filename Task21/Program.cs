// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Координаты точки A по оси(x)");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координаты точки A по оси(y)");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координаты точки A по оси(z)");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координаты точки B по оси(x)");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координаты точки B по оси(y)");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координаты точки B по оси(z)");
int z2 = Convert.ToInt32(Console.ReadLine());
double res = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
double ress = Math.Round(res, 2);  //два знака
Console.WriteLine(ress);