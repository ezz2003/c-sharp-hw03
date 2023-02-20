// 20. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
// A(3, 6); B(2, 1) -> 5.09
// A(7, -5); B(1, -1) -> 7.21

int InputInt(string mes)
{
  Console.Write(mes);
  return Convert.ToInt32(Console.ReadLine());
}

double CalculateDistance2D(int ax, int ay, int bx, int by)
{
  return Math.Round(Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2)), 2, MidpointRounding.ToZero);
}

int x1 = InputInt("Введите координату Х первой точки: ");
int y1 = InputInt("Введите координату Y первой точки: ");
int x2 = InputInt("Введите координату X второй точки: ");
int y2 = InputInt("Введите координату Y второй точки: ");

Console.WriteLine(CalculateDistance2D(x1, y1, x2, y2));


