// Задача 21
// 
// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// 
// A (3,6,8); B (2,1,-7), -> 15.84
// 
// A (7,-5, 0); B (1,-1,9) -> 11.53

int InputInt(string mes)
{
  Console.Write(mes);
  return Convert.ToInt32(Console.ReadLine());
}

double CalculateDistance3D(int ax, int ay, int az, int bx, int by, int bz)
{
  return Math.Round(Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2)), 2, MidpointRounding.ToZero);
}

int x1 = InputInt("Введите координату Х первой точки: ");
int y1 = InputInt("Введите координату Y первой точки: ");
int z1 = InputInt("Введите координату Z первой точки: ");
int x2 = InputInt("Введите координату X второй точки: ");
int y2 = InputInt("Введите координату Y второй точки: ");
int z2 = InputInt("Введите координату Z второй точки: ");

Console.WriteLine($" Расстояние между указанными точками - {CalculateDistance3D(x1, y1, z1, x2, y2, z2)}");