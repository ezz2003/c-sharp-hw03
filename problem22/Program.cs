// 22. Напишите программу, которая принимает на вход число N и выдаёт таблицу квадратов чисел от 0 до N.

void PrintSquareNumber(int n)
{ 
  if (n < 0) n = n * -1;
  for (int i = 1; i <= n; i++)
  {
    Console.WriteLine($"{i, 5} {Math.Pow(i, 2), 15}");
  }
}

Console.WriteLine("Программа выведет таблицу квадратов чисел от 1 до заданного Вами числа");
Console.Write("Задайте число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Clear();
PrintSquareNumber(number);
