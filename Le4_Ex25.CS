using System;

class Program 
{
    static int stepen (int x, int y)
    {
      int z=1;
      for (int i=0; i<y; i++) 
      {
      z=z*x;
      }
      return z;
    }
    static void Main(string[] args) 
    {
      Console.Write("Введите число A: ");
      int a = Convert.ToInt32(Console.ReadLine());
      Console.Write("Введите число B: ");
      int b = Convert.ToInt32(Console.ReadLine()); 
      Console.Write($"Число {a} в степени {b} = "+stepen (a,b));
    }
}
