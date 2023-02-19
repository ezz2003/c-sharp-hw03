// 18. Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (Х и Y)

int InputInt(string mes)
{
  Console.Write(mes);
  return Convert.ToInt32(Console.ReadLine());
}

string GetCoordinatesRange(int quart)
{
  string temp = $"Диапазон значений {quart} четверти -- ";
  if (quart == 1) return $" {temp} x > 0, y > 0";
  if (quart == 2) return $" {temp} x < 0, y > 0";
  if (quart == 3) return $" {temp} x < 0, y < 0";
  if (quart == 4) return $" {temp} x > 0, y < 0";
  return "Недопустимая четверть";
}

int quarter = InputInt("Введите номер четверти координатной плоскости: ");
Console.WriteLine(GetCoordinatesRange(quarter));
