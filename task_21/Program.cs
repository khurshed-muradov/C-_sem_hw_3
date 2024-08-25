// Задача 21: Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Cordinate(string message)
{
    System.Console.WriteLine(message);
    int im_cordanate = int.Parse(Console.ReadLine()!);
    return im_cordanate;
}

int x1 = Cordinate("Введите кординату X1: "); // Координаты первой точки А
int y1 = Cordinate("Введите кординату Y1: "); // Координаты первой точки А
int z1 = Cordinate("Введите кординату Z1: "); // Координаты первой точки А
int x2 = Cordinate("Введите кординату Х2: "); // Координаты первой точки В
int y2 = Cordinate("Введите кординату Y2: "); // Координаты первой точки В
int z2 = Cordinate("Введите кординату Z2: "); // Координаты первой точки В

double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)); //Формула Евклидова расстояния
System.Console.WriteLine(result);