using System;

class Program 
{

  static void Main(string[] args) 
    {
      Console.WriteLine("Введите координату k1:");
      double k1 = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Введите координату b1:");
      double b1 = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Введите координату k2:");
      double k2 = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Введите координату b2:");
      double b2 = Convert.ToDouble(Console.ReadLine());
      double x0 = (b2-b1)/(k1-k2);
      double y0 = k1*x0+b1;
      Console.WriteLine("");
      Console.WriteLine($"Координаты пересечения ({x0};{y0}) ");
     
    }
}
