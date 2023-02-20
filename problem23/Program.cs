// Задача 23
// 
// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void PrintThirdPowerNumbers(int n)
{ 
  if (n < 0) n = n * -1;
  for (int i = 1; i <= n; i++)
  {
    Console.WriteLine($"{i, 5} {Math.Pow(i, 3), 15}");
  }
}

Console.WriteLine("Программа выведет таблицу кубов (третьей степени) чисел от 1 до заданного Вами числа");
Console.Write("Задайте число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Clear();
PrintThirdPowerNumbers(number);
