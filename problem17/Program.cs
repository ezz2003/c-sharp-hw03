// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X != 0, Y != 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
// 
// 

int Quarter(int x, int y)
{
  if(x > 0 && y > 0) return 1;
  if(x < 0 && y > 0) return 2;
  if(x < 0 && y < 0) return 3;
  if(x > 0 && y < 0) return 4;
  return 0;
}


Console.Write("Введите координату Х: ");
int xc = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int yc = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xc, yc);
string answer = quarter > 0 ? $"Указаны координаты {quarter} четверти" : $"Введены недопустимые координаты";
Console.WriteLine(answer);
