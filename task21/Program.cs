/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите координаты первой точки (x, y, z):");

int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки (x, y, z):");

int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());


double pow_x = (x2 - x1)*(x2 - x1);
double pow_y = (y2 - y1)*(y2 - y1);
double pow_z = (z2 - z1)*(z2 - z1);

double distance = Math.Sqrt (pow_x + pow_y + pow_z);

Console.WriteLine("Расстояние между точками: " + distance);


