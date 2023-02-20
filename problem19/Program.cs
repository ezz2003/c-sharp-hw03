// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 
// 14212 -> нет
// 
// 12821 -> да
// 
// 23432 -> да
// 
// 

int Reverse(int num)
{
  int rotate = 0;
  while (num > 0) 
  { 
    rotate = rotate * 10 + num % 10; 
    num = num / 10; 
  }
  return rotate;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Утверждение, что число {number} является палиндромом - {Reverse(number)==number}");
