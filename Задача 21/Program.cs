// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

static double Distance3d (int xA, int yA, int zA, int xB, int yB, int zB)
{
    double dis = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
    return dis;
}

int GetInfo(string message)
{
    Console.Write(message);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}
    
int coorA1 = GetInfo ("Введите координату X точки А: ");
int coorA2 = GetInfo ("Введите координату Y точки А: ");
int coorA3 = GetInfo ("Введите координату Z точки А: ");
int coorB1 = GetInfo ("Введите координату X точки B: ");
int coorB2 = GetInfo ("Введите координату Y точки B: ");
int coorB3 = GetInfo ("Введите координату Z точки B: ");

Console.WriteLine(Distance3d(coorA1, coorA2, coorA3, coorB1, coorB2, coorB3));

